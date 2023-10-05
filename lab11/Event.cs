using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Event
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        private int SecretKey { get; set; }
        public List<User> Participants {get;set;}
        public Event(DateTime date,string description,int secretKey,List<User> participants)
        {
            Date = date;
            Description = description;
            SecretKey = secretKey;
            Participants = participants;
        }
       
    }
}
