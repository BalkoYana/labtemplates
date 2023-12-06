using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class System
    {
        private Authorization authorization;
        public void SetAuthorization(Authorization auth)
        {
            authorization = auth;
        }
        public void Authorize()
        {
            if (authorization != null)
            {
                bool result = authorization.Authorize();
                if (result)
                {
                    Console.WriteLine("Привіт!");
                }
                else
                {
                    Console.WriteLine("Авторизація невдала");
                }
            }
            else
            {
                Console.WriteLine("Алгоритм авторизації не встановлено");
            }
        }
    }
}
