using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class Fuel:IStorable
    {
        public double Amount{set;get;}
        public void HowMuchLeft(){System.Console.WriteLine("Fuel supply:"+Amount);}
    }
}