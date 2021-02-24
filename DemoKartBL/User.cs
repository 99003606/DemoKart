using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKart
{
    public class User
    {

        public String Username { get; set; }
        public String Password { get; set; }

        public User(String admin, String password)
        {
            Username = admin;
            Password = admin;

        }

    }
}
