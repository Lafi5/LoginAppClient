using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LoginAppClient
{
    [Serializable()]
    [DataContract]
    public class User
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Code { get; set; }
        public string Username { get; set; }

        public User()
        {
            FirstName = "";
            LastName = "";
            Code = "";
        }

        public User(string firstname, string lastName, string code)
        {
            FirstName = firstname;
            LastName = lastName;
            Code = code;
            GenerateUserName();
        }

        private void GenerateUserName()
        {
            Username = FirstName.ToLower().Substring(0, 1) + LastName.ToLower();
        }

        public string GetName()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
}
