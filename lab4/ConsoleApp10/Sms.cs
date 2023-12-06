using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Sms : Authorization
    {
        private string code;
        public Sms()
        {
            Random random = new Random();
            code = random.Next(1000, 10000).ToString();
        }

        public bool Authorize()
        {
            Console.WriteLine($"Надіслано СМС з кодом: {code}");
            Console.WriteLine("Введіть код з СМС:");
            string inputCode = Console.ReadLine();
            if (inputCode == code)
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
