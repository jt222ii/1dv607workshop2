using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2.Model
{
    class Member
    {
        private int memberID;
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
             FirstName = fName;
             LastName = lName;
             SSN = ssn;
         }
    }
}
