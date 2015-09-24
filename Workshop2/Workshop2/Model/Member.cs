using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2.Model
{
    class Member
    {
        private int _memberID;
        private string _firstName = "";
        private string _lastName = "";
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

         public Member(string fName, string lName, int ssn)
         {
             if (String.IsNullOrWhiteSpace(fName) || String.IsNullOrWhiteSpace(lName))//får inte låta namnen vara null i början. String är nullable
             {
                 throw new Exception();
             }
             FirstName = fName;
             LastName = lName;
             SSN = ssn;
             //_memberID = memberID; //unikt id hur?
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
