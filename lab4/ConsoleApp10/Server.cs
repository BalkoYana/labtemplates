using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Server : Authorization
    {
        private string[] services = { "Гугл", "Фейсбук", "Дія" };
        public bool Authorize()
        {
            Console.WriteLine("Виберіть сервіс для авторизації:");
            for (int i = 0; i < services.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {services[i]}");
            }
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber > 0 && inputNumber <= services.Length)
            {

                Console.WriteLine($"Зроблено запит до сервісу {services[inputNumber - 1]}");
                Console.WriteLine("Введіть логін:");
                string inputLogin = Console.ReadLine();
                return true;
            }
            else { return true; }
        }
    }
}
