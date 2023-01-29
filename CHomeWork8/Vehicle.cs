using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CHomeWork8
{
    internal class Vehicle
    {
        public string Brand;
        public string Model;
        public double Mileage;

        public Vehicle(string brand, string model, double mileage)
        {
            Brand = brand;
            Model = model;
            Mileage = mileage;
        }
    }
}
