using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Decorator:MainClass
    {
        private Dictionary<string, int> login;
        public Decorator(Search s) : base(s)
        {
            login = new Dictionary<string, int>();
        }
        public override List<string>search(string query)
        {
            DateTime time = DateTime.Now;
            Console.WriteLine($"[{time}] {query}");
           
            if (login.ContainsKey(query))
            {
                login[query]++;
            }
          
            else
            {
                login.Add(query, 1);
            }

           
            return s.search(query);
        }
        public void ShowTop(int number)
        {
            
            var sortedLogin = login.OrderByDescending(pair => pair.Value);

            
            Console.WriteLine($"ТОП {number} запитів:");
            foreach (var pair in sortedLogin.Take(number))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
    
}
