using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2.View
{
    class Console
    {
        public void DisplayInstructions()
        {

            System.Console.WriteLine("Here are instruascthasn");
            System.Console.WriteLine("Press '0' to quit the application.");
        
        }

        public int GetUserChoice()
        {
            int input = Convert.ToInt32(System.Console.ReadLine());

            return input;
        }
   
    }
}
