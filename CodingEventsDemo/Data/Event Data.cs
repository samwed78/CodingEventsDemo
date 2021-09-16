using System;
using System.Collections.Generic;
using CodingEventsDemo.Models;


namespace CodingEventsDemo.Data
{
    public class EventData
    {

        //store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        //add events
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        //retreive events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        //retreive a single event
        public static Event GetById(int Id)
        {
            return Events[Id];
        }

        //remove event
        public static void Remove(int id)
        {
            Events.Remove(id);
        }



        //edit
        public static void Edit(int eventId, string name, string description)
        {
            Events[eventId].Name = name;
            Events[eventId].Description = description;

        
        }
    }
}
