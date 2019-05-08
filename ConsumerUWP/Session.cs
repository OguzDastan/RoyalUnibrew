using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ConsumerUWP.ViewModels
{
    class Session
    {
        public Session()
        {
        }


        public User CurrentUser { get; set; }

        public bool Login(string UserName, string Password)
        {
            CurrentUser = new User(){UserName = UserName, Password = Password, AccessLevel = User.AccessLevels.USER};
            if (CurrentUser.UserName == "admin")
            {
                CurrentUser.AccessLevel = User.AccessLevels.ADMIN;
            }

            return true;
        }
    }
}
