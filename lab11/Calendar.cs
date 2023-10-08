using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Calendar
    {
        public static List<Event> Events { get; set; }
        public Calendar()
        {
            Events = new List<Event>();

        }
        public void AddEvent(Event newEvent)
        {
            Events.Add(newEvent);
            
        }
        public void Message()
        {
            foreach (var item in Events)
            {
                Console.WriteLine($"Date: {item.Date}, Description: {item.Description}");
                if (item is Meetings meetings)
                {
                    Console.WriteLine($"Start Time: {meetings.StartTime}, End Time: {meetings.EndTime}");
                }
                else if (item is Birthday birthday)
                {
                    Console.WriteLine($"Birthday Person: {birthday.Person.Login} {birthday.Person.Email}");
                }
                Console.WriteLine();
                
            }
            
        }
     
        public Event CopyEvent (Event anyEvent,  DateTime date,string description)
        {
            var copyanyEvent = anyEvent.Clone();
            copyanyEvent.Date = date;
            copyanyEvent.Description = description;
            Console.WriteLine();
            AddEvent(copyanyEvent);
            return copyanyEvent;
            
        }

      
    }
}
