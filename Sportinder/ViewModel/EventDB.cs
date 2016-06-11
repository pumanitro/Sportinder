using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportinder.ViewModel
{
    class EventDB
    {
        public static ObservableCollection<Event> getEvents()
        {
            DateTimeOffset dataNow = DateTimeOffset.Now;
            ObservableCollection<Event> Events = new ObservableCollection<Event>();
            Events.Add(new Event { ID = 1, Name = "Jhon Cena", Category = "CS: GO", Date = dataNow, Longitude = 4.8921, Latitude = 52.3712, SlotsMin = 2, SlotsMax = 5, Description = "Awesome CS: GO tournament" });
            Events.Add(new Event { ID = 2, Name = "Patryk Janik", Category = "League of Legends", Date = dataNow, Longitude = 5.8921, Latitude = 51.3712, SlotsMin = 7, SlotsMax = 10, Description = "Awesome LOL tournament" });
            Events.Add(new Event { ID = 3, Name = "Jakub Izbicki", Category = "Tennis", Date = dataNow, Longitude = 6.8921, Latitude = 53.3712, SlotsMin = 4, SlotsMax = 5, Description = "Awesome tennis tournament" });
            Events.Add(new Event { ID = 4, Name = "Mikoaj Kosowski", Category = "Football", Date = dataNow, Longitude = 3.8921, Latitude = 50.3712, SlotsMin = 10, SlotsMax = 20, Description = "Awesome football tournament" });
            Events.Add(new Event { ID = 5, Name = "Mateusz Gnyp", Category = "DOTA 2", Date = dataNow, Longitude = 4.7921, Latitude = 51.6712, SlotsMin = 3, SlotsMax = 5, Description = "DOTA 2 tournament" });
            Events.Add(new Event { ID = 6, Name = "Jhon Cena", Category = "Hearthstone", Date = dataNow, Longitude = 4.8921, Latitude = 52.3712, SlotsMin = 5, SlotsMax = 5, Description = "Awesome HS tournament" });
            return Events;

         }
    }
}
