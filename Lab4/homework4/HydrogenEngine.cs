using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class HydrogenEngine:Engine
    {
        public override void OneDayOfTravel(){}
        public override double Refill(double amount){
            return amount +=amount;
        }

    }
}