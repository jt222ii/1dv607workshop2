﻿using System;
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
        private List<Boat> boatList = new List<Boat>();

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                { _firstName = value; }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            
            set 
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _lastName = value;
                }
            }
        }
        public string SSN
        {
            get { return _SSN; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _SSN = value;
                }
            }
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
    }
}



