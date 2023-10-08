using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Meetings:Event
    {
       
            public  DateTime StartTime { get; set; }
            public  DateTime EndTime { get; set; }
        
        public Meetings(DateTime date, string description, int secretKey, List<User> participants, DateTime startTime, DateTime endTime):base(date,description,secretKey,participants)
        {
            StartTime = startTime;
            EndTime = endTime;

        }
        public override Event Clone()
        {
            Meetings clone = this.MemberwiseClone() as Meetings;
            clone.Participants = new List<User>();
            

            for (int i = 0; i < this.Participants.Count; i++)
            {
                clone.Participants.Add(this.Participants[i].Clone());
            }
            return clone;

        }

    }
}
