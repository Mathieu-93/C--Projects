using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class FoodSupply:IStorable
    {
        public double Amount{get;set;}
        public void HowMuchLeft(){System.Console.WriteLine("Food Supply:"+Amount);}
    }
}