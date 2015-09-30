using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2.Model
{
    //https://msdn.microsoft.com/en-us/library/ms973893.aspx
    //https://msdn.microsoft.com/en-us/library/c5sbs8z9(v=vs.110).aspx
    [Serializable]//fixa så skiten fungerar 
    class Member
    {
        private string _memberID;
        private string _firstName;
        private string _lastName;
        private string _SSN;

        //nån jävla lista med båtar som varje medlem ska fåååå LIST<BÅET> båtliest;
        //alla medlemmar ska ju ha en båt varför annars är de med i en båtklubb
        //jävla wannabes

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }
        public string MemberID
        {
            get { return _memberID; }
        }

        public Member(string fName, string lName, string ssn)
        {

            if (String.IsNullOrWhiteSpace(fName) || String.IsNullOrWhiteSpace(lName))//får inte låta namnen vara null i början. String är nullable
            {
                throw new Exception();
            }
            FirstName = fName;
            LastName = lName;
            SSN = ssn;
            _memberID = Guid.NewGuid().ToString();
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
                SSN = ssn;
            }
        }
    }
}



