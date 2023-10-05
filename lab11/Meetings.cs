using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Meetings:Event
    {
       
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
        
        public Meetings(DateTime date, string description, int secretKey, List<User> participants, DateTime startTime, DateTime endTime):base(date,description,secretKey,participants)
        {
            StartTime = startTime;
            EndTime = endTime;

        }
    }
}
