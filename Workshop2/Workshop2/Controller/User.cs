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
            Member m; //= new Member();
            Boat b = new Boat();

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
                    string name = c.GetUserInput();
                    string lastName = c.GetUserInput();
                    int SSN = Convert.ToInt32(c.GetUserInput());

                    m = new Member(name, lastName, SSN);
                    Console.WriteLine(m.FirstName);
                    break;
            }
        }
    }
}
