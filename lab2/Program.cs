using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Вказати структурний шаблон, який доцільно використати для розв'язування задачі.
//Розробити програмний прототип, який імітує діяльність відповідної системи, наприклад,
//замість надсилання SMS повідомлення вивести текст повідомлення в консоль. Провести демонстрацію роботи системи.


//Нехай дано пошукову систему яка приймає пошуковий запит користувача і надає йому відповідь –
//список URL сайтів (реалізувати як заглушку – на будь-який запит повертає однаковий список).
//Доповнити систему підсистемою логування, яка зберігає час і пошуковий запит непомітно для користувача в масиві.
//Також передбачити виводу ТОП N запитів, які
//отримувала система найчастіше.
namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Search searchEngine = new SearchList();

            Decorator logging = new Decorator(searchEngine);
           

            
            logging.search("коти");
            logging.search("собаки");
            logging.search("погода");
            logging.search("коти");
            logging.search("погода");
            logging.search("погода");
            var h = logging.search("коти");
            Console.WriteLine(h);

            logging.ShowTop(2);
        }
    }
}
