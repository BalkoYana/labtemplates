using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class User
    {
        private string Password { get; set; }
        public int Login { get; set; }
        public string Email { get; set; }
        public User(string password,int login,string email)
        {
            Password = password;
            Login = login;
            Email = email;
        }
        public User Clone()
        {
            return this.MemberwiseClone() as User;
        }
    }
}
