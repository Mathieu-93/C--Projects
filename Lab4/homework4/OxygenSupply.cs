using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class OxygenSupply:IStorable
    {
        public  double Amount{get;set;}
        public double MaxCapacity {get;set;}
        public void HowMuchLeft(){System.Console.WriteLine("Oxygen supply:"+Amount);}
        public  OxygenSupply(double capacity){
            this.MaxCapacity= capacity;
        }
    }
}

