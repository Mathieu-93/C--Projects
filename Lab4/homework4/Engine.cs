using System;
using System.Collections.Generic;
using System.Text;

namespace C4
{
    abstract class Engine
    {
        public abstract void CheckSupplies();
        public Engine(){}
        public abstract void OneDayOfTravel();
        public abstract double Refill(double amount);

    }
}