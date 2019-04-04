using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarInventory
{
    class Car
    {
        public string make, colour;
        public string year, mileage;
        
        public Car(string _make, string _colour, string _year, string _mileage)
        {
            make = _make;
            colour = _colour;
            year = _year;
            mileage = _mileage;
        }
    }
}
