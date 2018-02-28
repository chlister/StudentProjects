using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KroellOgCamrIRummet.Models
{
    public class Planet
    {
        private string name;
        private double temperature_day;
        private double temperature_night;
        private string day_length;
        private float perimeter;
        private string year_length;
        private int num_moons;
        public string Name { get { return name; } set { name = value; } }
        public double Temperature_Day { get { return temperature_day; } set { temperature_day = value; } }
        public double Temperature_Night { get { return temperature_night; } set { temperature_night = value; } }
        public string Day_Length { get { return day_length; } set { day_length = value; } }
        public float Perimeter { get { return perimeter; } set { perimeter = value; } }
        public string Year_Length { get { return year_length; } set { year_length = value; } }
        public int Num_Moons { get { return num_moons; } set { num_moons = value; } }

        public Planet(string _name, double _tempDay, double _tempNight, string _dayLength, float _perimeter, string _yearLength, int _moons)
        {
            Name = _name;
            Temperature_Day = _tempDay;
            Temperature_Night = _tempNight;
            Day_Length = _dayLength;
            Perimeter = _perimeter;
            Year_Length = _yearLength;
            Num_Moons = _moons;
        }
        public Planet()
        {

        }
    }
}
