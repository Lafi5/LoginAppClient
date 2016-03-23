using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAppClient
{
    class UserTextLoader : Loader<User>
    {
        List<User> userList = new List<User>();

        public UserTextLoader(string path, IContentReader reader) : base(path, reader)
        {

        }
        public override List<User> LoadUsers()
        {
            string content = contentReader.ReadFullContent(sourcePath);

            ProcessContent(content);

            return userList;
        }

        private void ProcessContent(string content)
        {
            string[] lines = content.Split(new string[] { "\r\n", "\n" },
                StringSplitOptions.RemoveEmptyEntries);


            foreach (string item in lines)
            {
                string[] values = item.Split(';');
                userList.Add(new User(values[0], values[1], values[2]));
            }
        }
    }
}
