using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   class SearchList : Search
    {
        
        public  List<string> search(string query) {
            return new List<string>()
            {
                "https://www.google.com",
                "https://github.com",
                "https://classroom.google.com",

            };
        }

    }
}
