using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2.Model
{
    class Member
    {
        private string _memberID;
        private string _firstName;
        private string _lastName;
        private int _SSN;


         public string FirstName
        {
            get {return _firstName; }
            set { _firstName = value; }
        }

         public string LastName
         {
             get { return _lastName; }
             set { _lastName = value; }
         }
         public int SSN
         {
             get { return _SSN; }
             set { _SSN = value; }
         }

         public Member(string fName, string lName, int ssn, int? id = null)
         {
             MemberDAL mDAL = new MemberDAL(); 

             if (String.IsNullOrWhiteSpace(fName) || String.IsNullOrWhiteSpace(lName))//får inte låta namnen vara null i början. String är nullable
             {
                 throw new Exception();
             }
        
             FirstName = fName;
             LastName = lName;
             SSN = ssn;

             if (id == 0)
             {
                 //string unique = Guid.NewGuid().ToString();
                 //Console.WriteLine(unique);
                 

                 mDAL.SaveMemberToTxt(fName, lName, ssn);
             }

             //_memberID = memberID; //unikt id hur? 
             //Första bokstav i för och efternamn och slumpa en sifferkombination kanske? 

             //sparar ner medlemen i en textfil behöver rensa den när vi implementerar id.
         }

         public void UpdateMember(string fName, string lName, string ssn) //vill kanske ha flera olika så man kan bestämma vad man vill ändra utan att behöva skriva i resten.
         {
             if (!String.IsNullOrWhiteSpace(fName))
             {
                 FirstName = fName;
             }
             if (!String.IsNullOrWhiteSpace(lName))
             {
                 LastName = lName;
             }
             if (!String.IsNullOrWhiteSpace(ssn))
             {
                 SSN = int.Parse(ssn);
             }
         }



         
         }
    }



