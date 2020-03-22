using System;
using System.Collections.Generic;
using System.Text;

namespace C4
{
    class Waste:IStorable
    {
        private string name;
        public double Amount{get;set;}
        public void HowMuchLeft(){System.Console.WriteLine(Amount+" left");}
        public  Waste(string s){} 
    }
}
