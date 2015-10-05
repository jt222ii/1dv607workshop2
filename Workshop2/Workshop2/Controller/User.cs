using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
                    try
                    {
                        c.DisplayInstructions();
                        int userInput = int.Parse(c.GetUserInput());
                        IReadOnlyCollection<Member> list = mDAL.getMemberList();
                        switch (userInput)
                        {
                            case 1:
                                mDAL.SaveMembersToBin();
                                Environment.Exit(0);
                                break;
                            case 2:
                                Console.Clear();
                                while (true)
                                {
                                    //fname, lname, ssn
                                    c.addMemberMessage();
                                    try
                                    {
                                        m = new Member(c.GetUserInput(), c.GetUserInput(), c.GetUserInput());
                                        mDAL.addMemberToList(m);
                                    }
                                    catch
                                    {
                                        throw new ArgumentException();
                                    }
                                    break;
                                }

                                break;
                            case 3:
                                Console.Clear();
                                c.showMembersCompact(list);
                                selectMember(list);
                                break;
                            case 4:
                                Console.Clear();
                                c.showMembersVerbose(list);
                                selectMember(list);
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        c.ErrorMessage(e);
                    }
                }
        }

        public void selectMember(IReadOnlyCollection<Member> list)
        {
            int choice = int.Parse(c.GetUserInput());
            if (choice == 0)
            {
                return;
            }
            choice--;
            Member member = list.ElementAt(choice);
            c.showMember(member);
            int menuChoice = int.Parse(c.GetUserInput());
            switch (menuChoice)
            {
                case 1://remove member
                    mDAL.removeMemberFromList(choice);
                    break;
                case 2://change first name
                    member.FirstName = c.GetUserInput();
                    break;
                case 3://change last name
                    member.LastName = c.GetUserInput();
                    break;
                case 4://change ssn
                    member.SSN = c.GetUserInput();
                    break;
                case 5://add a boat
                    c.showBoatTypes();
                    int typeChoice = int.Parse(c.GetUserInput());
                    c.boatLengthPrompt();
                    double lengthInput = double.Parse(c.GetUserInput());
                    b = new Boat(typeChoice, lengthInput);
                    member.AddBoat(b);
                    break;
                case 6://view boats
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
            int choice = int.Parse(c.GetUserInput());
            if (choice == 0)
            {
                return;
            }
            choice--;
            Boat chosenBoat = member.BoatList.ElementAt(choice);
            c.showBoat(chosenBoat);
            int boatOption = int.Parse(c.GetUserInput());
            switch(boatOption){
                case 1:
                    c.showBoatTypes();
                    int newType = int.Parse(c.GetUserInput())-1;
                    c.boatLengthPrompt();
                    double newLength = double.Parse(c.GetUserInput());
                    member.ChangeBoat(chosenBoat, newType, newLength);
                    break;
                case 2:
                    member.RemoveBoat(choice);
                    break;
                default:
                    break;

        }
        }
    }
}
