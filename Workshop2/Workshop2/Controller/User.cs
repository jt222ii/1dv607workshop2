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
            Boat b = new Boat();
            MemberDAL mDAL = new MemberDAL();
            View.Console c = new View.Console(mDAL);
            mDAL.LoadMembersFromBin();

            c.DisplayInstructions();
            int userInput = c.GetUserChoice();

            switch (userInput)
            {
                case 0:
                    //KVITT APLLIKASHON
                    Environment.Exit(0);
                    break;
                case 1:
                    //Gör nåt annat
                    Console.WriteLine("You are now swaglord");
                    break;
                case 2:
                    Console.Clear();
                    while (true)
                    {
                        try
                        {
                            m = new Member(c.GetUserInput(), c.GetUserInput(), c.GetUserInput());
                            mDAL.addMemberToList(m);
                            Console.WriteLine("{0} {1} {2}", m.FirstName, m.LastName, m.SSN);
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
                    //try
                    //{
                        c.showMembers(mDAL.getMemberList());
                        c.showMember(mDAL.getMemberList(), c.GetUserChoice());
                    //}
                    //catch
                    //{
                    //    //NÅT GICK FEL NÄR MAN SKULLE HÄMTA ANVÄNDARE SOM EN READONLYLISTA LIKSOM VAFAAAN
                    //}
                    break;
                case 4:

                    break;
                    
            }
        }
    }
}
