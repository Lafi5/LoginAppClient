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
        }

        public string GetName()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
}
