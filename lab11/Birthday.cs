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
        public override Event Clone()
        {
            Birthday clone = this.MemberwiseClone() as Birthday;
            clone.Participants = new List<User>();
            for (int i = 0; i < this.Participants.Count; i++)
            {
                clone.Participants.Add(this.Participants[i].Clone());
            }
            return clone;

        }
    }
}
