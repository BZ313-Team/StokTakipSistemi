using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.model
{
    internal class UserModel
    {
        private String password;
        private String userName;

        public UserModel(String userName, String password)
        {
            this.password = password;
            this.userName = userName;
        }

        public String getPassword() { 
            return this.password; 
        }

        public String getUserName()
        {
            return this.userName;
        }
    }
}
