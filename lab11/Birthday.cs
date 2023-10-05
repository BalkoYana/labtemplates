using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Birthday:Event
    {
        public User Person { get; set; }
        public Birthday(DateTime date, string description, int secretKey, List<User> participants,User person) : base(date, description, secretKey, participants)
        {
            Person = person;
        }
    }
}
