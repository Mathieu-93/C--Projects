using System;

namespace Lab2
{
    abstract  class Vehicle:IVehicle
    {
        public virtual void ShowData(){
            Console.WriteLine("Unspecified vehicle");
        }
    }
}
