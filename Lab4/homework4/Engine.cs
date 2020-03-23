using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    abstract class Engine
    {
        protected Fuel fuel =new Fuel();
        public virtual void CheckSupplies(){
            Console.WriteLine("Fuel supply: "+fuel.Amount);
        }
        public Engine(){
            fuel.Amount =100;
        }
        public abstract void OneDayOfTravel();
        public abstract double Refill(double amount);

    }
}