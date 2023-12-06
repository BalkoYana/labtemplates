using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class LoginAndPassword : Authorization
    {
        private const string login = "login";
        private const string password = "1111";

        public bool Authorize()
        {
            Console.WriteLine("Введіть логін:");
            string inputLogin = Console.ReadLine();
            Console.WriteLine("Введіть пароль:");
            string inputPassword = Console.ReadLine();
            if (inputLogin == login && inputPassword == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
