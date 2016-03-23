using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAppClient
{
    class LoginFormViewModel
    {
        private List<User> users { get; set; }  

        public bool IsUserLoggedIn { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        private string UserListFileNameCSV = "codes.csv";


        public LoginFormViewModel()
        {
            IsUserLoggedIn = false;
            users = new List<User>();

            LoadUserList();
        }

        private void LoadUserList()
        {
            users = new UserTextLoader(UserListFileNameCSV, new FileReader()).LoadUsers();
        }

        public bool ManageLogin(string username, string password)
        {
            if (!IsUserLoggedIn)
            {
                Login(username, password);

                if (IsUserLoggedIn)
                {
                    Log.Write(string.Format("{0} {1}", IsUserLoggedIn, UserName));
                    return true;
                }
                else
                {
                    Log.Write(string.Format("{0} {1}", IsUserLoggedIn, UserName));
                    return false;
                }
            }
            else
            {
                //Logout();
                Log.Write(string.Format("Logout {0}", UserName));
                return false;
            }
        }

        private void Login(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username.Equals(username) && user.Code.Equals(password))
                {
                    IsUserLoggedIn = true;
                    break;
                }
                else
                {
                    IsUserLoggedIn = false;
                }
            }
        }
    }
}
