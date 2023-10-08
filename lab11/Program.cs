using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            User user1 = new User("bddif", 557884, "ddff@fff.f");
            User user2 = new User("gghhf",688346, "ddsf@gg.gg");
            User user3 = new User("ssdff", 557666, "dfff@fhh.f");
            List<User> participants = new List<User> { user1, user2,user3 };
            Meetings meeting = new Meetings(DateTime.Parse("04/05/2007 2:30:00 PM"), "description", 775554, participants, DateTime.Parse("2:30:00 PM"), DateTime.Parse("3:30:00 PM"));
            Birthday birthday = new Birthday(DateTime.Parse("03/09/2000 2:30:00 PM"), "fsdgfdg", 776755, participants, user3);
            Calendar calendar = new Calendar();
            calendar.AddEvent(meeting);
            calendar.AddEvent(birthday);
            calendar.CopyEvent(meeting, DateTime.Parse("07/12/2199 2:30:00 PM"), "text2");
            calendar.CopyEvent(birthday, DateTime.Parse("07/12/2199 2:30:00 PM"),"text2");
            calendar.Message();
            
            

        }
    }
}
