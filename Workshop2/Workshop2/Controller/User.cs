using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop2.Model;

namespace Workshop2.Controller
{
    class User
    {
        Member m;
        Boat b;
        MemberDAL mDAL;
        View.Console c;
   
        public void StartApplication()
        {
           
            mDAL = new MemberDAL();
            c = new View.Console(mDAL);
            mDAL.LoadMembersFromBin();
            while (true)
            {
                c.DisplayInstructions();
                int userInput = c.GetUserChoice();
                IReadOnlyCollection<Member> list = mDAL.getMemberList();
                switch (userInput)
                {
                    case 0:
                        //KVITT APLLIKASHON
                        mDAL.SaveMembersToBin();
                        Environment.Exit(0);
                        break;
                    case 1:
                        //Gör nåt annat
                        Console.WriteLine("You are now swaglord, congrataruration!");
                        break;
                    case 2:
                        Console.Clear();
                        while (true)
                        {
                            try
                            {
                                //fname, lname, ssn
                                c.addMemberMessage();
                                m = new Member(c.GetUserInput(), c.GetUserInput(), c.GetUserInput());
                                mDAL.addMemberToList(m);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Något var inte korrekt ifyllt"); // får inte ha meddelandet i controllern flytta till view
                            }
                        }

                        break;
                    case 3:
                        Console.Clear();
                        try
                        {
                            c.showMembersCompact(list);
                            selectMember(list);
                        }
                        catch 
                        {
                            //nått gick fel
                        }
                        break;
                    case 4:
                        Console.Clear();
                        try
                        {      
                            c.showMembersVerbose(list);
                            selectMember(list);

                        }
                        catch
                        {
                            //NÅT GICK FEL NÄR MAN SKULLE HÄMTA ANVÄNDARE SOM EN READONLYLISTA LIKSOM VAFAAAN
                        }
                        break;

                }




            }

        }

        public void selectMember(IReadOnlyCollection<Member> list)
        {
            int choice = c.GetUserChoice();
            Member member = list.ElementAt(choice);
            c.showMember(member);
            int menuChoice = int.Parse(c.GetUserInput());
            switch (menuChoice)
            {
                case 1:
                    mDAL.removeMemberFromList(choice);
                    break;
                case 2:
                    member.FirstName = c.GetUserInput();
                    break;
                case 3:
                    member.LastName = c.GetUserInput();
                    break;
                case 4:
                    member.SSN = c.GetUserInput();
                    break;
                case 5:
                    //ad le boat LOL XD :DDDDD
                    c.showBoatTypes();
                    int typeChoice = int.Parse(c.GetUserInput());
                    c.boatLengthPrompt();
                    double lengthInput = double.Parse(c.GetUserInput());
                    b = new Boat(typeChoice, lengthInput);
                    member.AddBoat(b);
                    break;
                case 6:
                    c.chooseBoatPrompt();
                    c.showMemberBoats(member);
                    updateBoat(member);
                    break;
                default:
                    break;
            }
        }

        public void updateBoat(Member member)
        {
            int boatSpot = int.Parse(c.GetUserInput());
            Boat chosenBoat = member.BoatList.ElementAt(boatSpot);
            c.showBoat(chosenBoat);
            int boatOption = int.Parse(c.GetUserInput());
            switch(boatOption){
                case 1:
                    c.showBoatTypes();
                    int newType = int.Parse(c.GetUserInput());
                    c.boatLengthPrompt();
                    double newLength = double.Parse(c.GetUserInput());
                    member.ChangeBoat(chosenBoat, newType, newLength);
                    break;
                case 2:
                    member.RemoveBoat(boatSpot);
                    break;
                default:
                    break;
                //välj något giltigt för fan
        }
        }
    }
}
