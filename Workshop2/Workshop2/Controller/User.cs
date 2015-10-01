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
        public void StartApplication()
        {

            Member m;
            Boat b;
            MemberDAL mDAL = new MemberDAL();
            View.Console c = new View.Console(mDAL);
            mDAL.LoadMembersFromBin();



            while (true)
            {
                c.DisplayInstructions();
                int userInput = c.GetUserChoice();

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
                            IReadOnlyCollection<Member> list = mDAL.getMemberList();
                            c.showMembers(list);
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
                                    
                                    b = new Boat();
                                   // Workshop2.Model.Boat.type.Canoe;
                                    
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch
                        {
                            //NÅT GICK FEL NÄR MAN SKULLE HÄMTA ANVÄNDARE SOM EN READONLYLISTA LIKSOM VAFAAAN
                        }
                        break;
                    case 4:

                        break;

                }




            }

        }
    }
}
