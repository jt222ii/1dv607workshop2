using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop2.Model;

namespace Workshop2.View
{
    class Console
    {
        MemberDAL mDAL;
        public Console(MemberDAL mD)
        {
            mDAL = mD;
        }
        public void DisplayInstructions()
        {
            System.Console.WriteLine("Here are instruascthasn");
            System.Console.WriteLine("Press '0' to save & quit the application.");
            System.Console.WriteLine("Press '1' to become the swaglord.");
            System.Console.WriteLine("Press '2' to add a member.");
            System.Console.WriteLine("Press '3' to view members");
        }
        public void testInstructions() //ska tas bort/ändras
        {
            System.Console.WriteLine("change member info (entering nothing changes nothing): \n");
        }

        public int GetUserChoice()
        {
            return Convert.ToInt32(System.Console.ReadKey().KeyChar.ToString());
        }

        public string GetUserInput()
        {
            return System.Console.ReadLine();
        }

        public void showMembers(IReadOnlyCollection<Member> list)
        {
            int number = 0;
            foreach (Member member in list)
            {
                System.Console.WriteLine("{4}: {0}, {1}, {2}, UNIKT ID: {3}",
                                    member.FirstName,
                                    member.LastName,
                                    member.SSN,
                                    member.MemberID,
                                    number);
                number++;
               System. Console.WriteLine("════════════════════════════════════════════════════");
            }
        }

        public void showMember(Member member)
        {         
            System.Console.WriteLine("{0}, {1}", member.FirstName, member.LastName);
            System.Console.WriteLine("What do you want to do?\n 1 - to delete\n 2 - to change First Name\n 3 - to change Last Name\n 4 - to change Social security number");
        }
    }
}
