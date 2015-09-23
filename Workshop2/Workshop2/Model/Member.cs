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
        private string firstName;
        private string lastName;
        private int sSN;

         public string FirstName
        {
            get {return firstName; }
            set {value = firstName;}
        }

         public string LastName
         {
             get { return lastName; }
             set { value = lastName; }
         }
         public int SSN
         {
             get { return sSN; }
             set { value = sSN; }
         }

         public Member()
         {

         }


    }
}
