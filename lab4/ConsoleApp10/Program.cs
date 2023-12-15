using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
//3.Система дає змогу користувачу вибрати
//    спосіб авторизації: Це може бути
//    авторизація за допомогою логіну і паролю
//    (пара вірних задаються літералом), 
//    або авторизація кодом із СМС (надсилання 
//    СМС імітувати за допомогою відповідного 
//    повідомлення консоль), або авторизація за
//    допомогою зовнішнього серверу (імітувати запит,
//    вважати що після вибору сервісу (Гугл, Фейсбук
//    чи Дія) і введення логіну така авторизація
//    завжди успішна). Авторизованому користувачу
//    система повинна передати повідомлення "Привіт!"
namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
{
    System system = new System();
    Authorization loginPassword = new LoginAndPassword();
    Authorization smsCode = new Sms();
    Authorization externalServer = new Server();

    Console.WriteLine("Виберіть спосіб авторизації:");
    Console.WriteLine("1. Логін та пароль");
    Console.WriteLine("2. SMS");
    Console.WriteLine("3. Зовнішній сервер");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            system.SetAuthorization(loginPassword);
            break;
        case "2":
            system.SetAuthorization(smsCode);
            break;
        case "3":
            system.SetAuthorization(externalServer);
            break;
        default:
                    Console.WriteLine("Помилка");
                    break;
    }

    system.Authorize();
}

    }
}
