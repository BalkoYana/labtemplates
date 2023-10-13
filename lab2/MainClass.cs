using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class MainClass:Search
    {
        protected Search s;
        public MainClass(Search s)
        {
            this.s = s;
        }
        public abstract List<string> search(string query);
    }
}
