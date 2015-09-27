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
            View.Console c = new View.Console();
            Member m; 
            Boat b = new Boat();
            MemberDAL mDAL = new MemberDAL();
            //mDAL.LoadMembersFromTxt();
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
                            string name = c.GetUserInput();
                            string lastName = c.GetUserInput();
                            int SSN = Convert.ToInt32(c.GetUserInput());
                            m = new Member(name, lastName, SSN);
                            mDAL.addMemberToList(m);
                            Console.WriteLine("{0} {1} {2}", m.FirstName, m.LastName, m.SSN);
                            break;
                        }
                        catch
                        {
                            
                            Console.WriteLine("Något var inte korrekt ifyllt"); // får inte ha meddelandet i controllern flytta till view
                        }
                    }
          

                    //testkod för ändring av medlem
                    c.testInstructions();
                    string newName = c.GetUserInput();
                    string newLastName = c.GetUserInput();
                    string newSSN = c.GetUserInput(); // vill ha int fan men går inte att skriva in null värde för int med "int? newSSN = Convert.ToInt32(c.GetUserInput());"
                    m.UpdateMember(newName, newLastName, newSSN);
                    Console.WriteLine("{0} {1} {2}", m.FirstName, m.LastName, m.SSN);
                    //slut på testkod

                    break;
            }
        }
    }
}
