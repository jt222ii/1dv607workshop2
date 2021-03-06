﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2.Model
{
    class MemberDAL
    {
        private List<Member> memberList = new List<Member>();
        private const string _path = @"MemberBin.bin";

        public void addMemberToList(Member member)
        {
            memberList.Add(member);
        }
        public IReadOnlyCollection<Member> getMemberList()
        {
            return memberList.AsReadOnly();
        }

        //http://www.dotnetperls.com/serialize-list
        public void SaveMembersToBin()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(_path,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, memberList);
            stream.Close();
        }
        public void LoadMembersFromBin() 
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            try
            {
                memberList = (List<Member>)formatter.Deserialize(stream);
            }
            catch 
            {
                stream.Close();
                throw new Exception("Could not find BIN, a new file will be created.");
            }
            stream.Close();
        }
        public void removeMemberFromList(int choice)
        {
            memberList.RemoveAt(choice);
        }
    }
}
