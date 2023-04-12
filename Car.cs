using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Practice_1
{
    internal class Car
    {
        //Fields
        string _make;
        string _model;
        int _year;
        int _mileage;

        //Default Constructor with pre assigned parameters
        public Car()
        {
            _make = "Unassigned";
            _model = "Unassigned";
            _year = 0;
            _mileage = 0;
        }

        //Overload constructor with two required parameters and two pre assigned parameters
        public Car(string make, string model)
        {
            _make = make;
            _model = model;
            _year = 0;
            _mileage = 0;
        }

        //Overload constructor with all field parameters required
        public Car(string make, string model, int year, int mileage)
        {
            _make = make;
            _model = model;
            _year = year;
            _mileage = mileage;
        }

        //Properties
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }

        //override ToString() to display car parameters from this specific class.

        public override string ToString()
        {
            return $"{_year} {_make} {_model} - {_mileage}";
        }
    }

}
