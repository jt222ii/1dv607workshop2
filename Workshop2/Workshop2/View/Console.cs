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
            System.Console.Clear();
            System.Console.WriteLine("╔═══════════════════════════════════════════════╗");
            System.Console.WriteLine("║                 Welcome!                      ║");
            System.Console.WriteLine("║Press '1' to save & quit the application.      ║");
            System.Console.WriteLine("║Press '2' to add a member.                     ║");
            System.Console.WriteLine("║Press '3' to view compact memberlist           ║");
            System.Console.WriteLine("║Press '4' to view verbose memberlist           ║");
            System.Console.WriteLine("╚═══════════════════════════════════════════════╝");
        }
        public string GetUserInput()
        {
            return System.Console.ReadLine();
        }

        public void showMembersVerbose(IReadOnlyCollection<Member> list)
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
                System.Console.WriteLine("Boats: ");
                showMemberBoats(member);
               System. Console.WriteLine("════════════════════════════════════════════════════");
            }
            listInstruction();
        }
        public void showMembersCompact(IReadOnlyCollection<Member> list)
        {
            int number = 0;
            foreach (Member member in list)
            {
                int boatAmount = member.BoatList.Count();
                System.Console.WriteLine("{4}: {0}, {1}, UniqueID: {3}, Boats: {2}",
                                    member.FirstName,
                                    member.LastName,
                                    boatAmount,
                                    member.MemberID,
                                    number);
                number++;
                System.Console.WriteLine("════════════════════════════════════════════════════");
            }
            listInstruction();
        }
        public void listInstruction()
        {
            System.Console.WriteLine("Choose a member. \"Q\" to go back to main menu(INTE IMPLEMENTERAT ÄNNU)");
        }

        public void showMember(Member member)
        {
            System.Console.Clear();
            System.Console.WriteLine("Name: {0} {1} SSN: {2} ID: {3}", member.FirstName, member.LastName, member.SSN, member.MemberID);
            showMemberBoats(member);
            System.Console.WriteLine("════════════════════════════════════════════════════\n");
            System.Console.WriteLine("What do you want to do?\n 1 - to delete\n 2 - to change First Name\n 3 - to change Last Name\n 4 - to change Social security number\n 5 - Add a boat\n 6 - Inspect boat");
        }
        public void showMemberBoats(Member member)
        {
            int boatNumber = 0;
            foreach (Boat boat in member.BoatList)
            {
                System.Console.WriteLine(string.Format("\t{0}: TYPE: {1}, LENGTH: {2}m", boatNumber, boat.BoatType.ToString(), boat.Length));
                boatNumber++;
            }
        }

        public void showBoatTypes()
        {
            System.Console.Clear();
            System.Console.WriteLine("Select a boat type:");
            var BoatTypes = Enum.GetValues(typeof(Boat.type)).Cast<Boat.type>();
            int i = 0;
            foreach (Enum Type in BoatTypes)
            {
                System.Console.WriteLine(String.Format("{0}: {1}",i ,Type));
                i++;
            }
        }
        public void showBoat(Boat boat)
        {
            System.Console.Clear();
            System.Console.WriteLine(String.Format("TYPE: {0} LENGTH: {1}", boat.BoatType, boat.Length));
            System.Console.WriteLine("1: Edit Boat\n2: Remove Boat");
        }
        public void boatLengthPrompt()
        {
            System.Console.Clear();
            System.Console.WriteLine("Enter the length of the boat(meter)");
        }
        public void addMemberMessage() 
        {
            System.Console.Clear();
            System.Console.WriteLine("Enter your first name, last name and social security number(yyyymmdd-XXXX)");
        }
        public void chooseBoatPrompt()
        {
            System.Console.Clear();
            System.Console.WriteLine("Choo Choo Choose a boat");
        }

        public void ErrorMessage()
        {
            System.Console.WriteLine("Something have gone wrong. Press any key to continue");
            System.Console.ReadKey();
        }
    }
}
