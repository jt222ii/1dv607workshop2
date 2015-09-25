using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2.Model
{
    class MemberDAL
    {
        private List<Member> memberList = new List<Member>();
        private const string _path = @"members.txt";

        public MemberDAL()
        {
    
        }
        public void LoadMembersFromTxt()
        {
            //return member objects 

            using (StreamReader reader = new StreamReader(_path, System.Text.Encoding.UTF8))
            {
                string line;

                string name = null;
                string lName = null;
                int SSN = 0; // skit i noll

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("[First name]"))
                    {
                        name = line.Split(':').Skip(1).FirstOrDefault();
                    }
                    if (line.Contains("[Last name]"))
                    {
                        lName = line.Split(':').Skip(1).FirstOrDefault();
                    }
                    if (line.Contains("[SSN]"))
                    {
                        SSN = int.Parse(line.Split(':').Skip(1).FirstOrDefault());
                    }
                    if (SSN != 0 && lName != null && name != null)
                    {
                        memberList.Add(new Member(name, lName, SSN, null));
                        name = null;
                        lName = null;
                        SSN = 0;
                    }
                }
            }

         }

        public void SaveMemberToTxt(string firstName, string lastName, int SSN)
        {
            string memberString = String.Format("[First name]:{0}\n[Last name]:{1}\n[SSN]:{2}\n", firstName, lastName, SSN);
            System.IO.File.AppendAllText(_path, memberString);
        }



    }
}
