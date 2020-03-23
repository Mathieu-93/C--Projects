using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class NuclearEngine:Engine
    {
        private Waste nuclearWaste;
        public override void CheckSupplies(){
            Console.WriteLine("Nuclear waste stored: "+nuclearWaste);
        }
        public NuclearEngine(){}
        public override void OneDayOfTravel(){
            Console.WriteLine("Fuel supply:"+ fuel.Amount );
        }
        public override double Refill(double amount){
            return amount +=amount;
        }

    }
}