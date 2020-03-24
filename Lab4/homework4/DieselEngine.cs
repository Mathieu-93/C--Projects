using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class DieselEngine:Engine
    {
        public override void OneDayOfTravel(){
            fuel.Amount-=10;
            fuel.HowMuchLeft();
        }
        public override double Refill(double amount){
            return fuel.Amount +=amount;
        }

    }
}