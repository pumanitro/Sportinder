using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportinder.ViewModel
{
    class Event
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private DateTimeOffset date;

        public DateTimeOffset Date
        {
            get { return date; }
            set { date = value; }
        }

        private double longitude;

        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        private double latitude;

        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        private int slotsMin;

        public int SlotsMin
        {
            get { return slotsMin; }
            set { slotsMin = value; }
        }

        private int slotsMax;

        public int SlotsMax
        {
            get { return slotsMax; }
            set { slotsMax = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


    }
}
