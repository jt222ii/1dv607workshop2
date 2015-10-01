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
                int boatNumber = 0;
                System.Console.WriteLine("Boats: ");
                foreach (Boat boat in member.BoatList)
                {
                    System.Console.WriteLine(string.Format("\t{0}: TYPE: {1}, LENGTH: {2}", boatNumber, boat.BoatType.ToString(), boat.Length));
                    boatNumber++;
                }
               System. Console.WriteLine("════════════════════════════════════════════════════");
            }
        }

        public void showMember(Member member)
        {         
            System.Console.WriteLine("{0}, {1}", member.FirstName, member.LastName);
            System.Console.WriteLine("What do you want to do?\n 1 - to delete\n 2 - to change First Name\n 3 - to change Last Name\n 4 - to change Social security number");
        }

        public void showBoatTypes()
        {
            System.Console.WriteLine("Select a boat type:");
            var BoatTypes = Enum.GetValues(typeof(Boat.type)).Cast<Boat.type>();
            int i = 0;
            foreach (Enum Type in BoatTypes)
            {
                System.Console.WriteLine(String.Format("{0}: {1}",i ,Type));
                i++;
            }
        }
        public void boatMessage()
        {
            System.Console.WriteLine("Enter the length of the boat");
        }
        public void addMemberMessage() 
        {
            System.Console.WriteLine("Enter your first name, last name and social security number(yyyymmdd-XXXX)");
        }
    }
}
