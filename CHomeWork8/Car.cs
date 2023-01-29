using System;
using System.Collections.Generic;
using System.Text;

namespace CHomeWork8
{
    internal class Car:Vehicle
    {
        public int FuelCapacity;
        public int CurrentFuel;


        public Car(int fuelCapacity, int currentFuel, string brand, string model, double mileage):base(brand,model,mileage)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
        }

        public bool AddFuel(int num)
        {
            if (CurrentFuel + num <= FuelCapacity)
            {
                CurrentFuel+= num;
                return true;
            }
            return false;
                
        }
    }
}
