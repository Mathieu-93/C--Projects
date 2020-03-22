using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class OxygenSupply:IStorable
    {
        public  double Amount{get;set;}
        public double MaxCapacity {get;set;}
        public void HowMuchLeft(){System.Console.WriteLine(Amount+" left");}
        public  OxygenSupply(double capacity){}
    }
}

