using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class Waste:IStorable
    {
        private string name;
        public double Amount{get;set;}
        public void HowMuchLeft(){System.Console.WriteLine(name+" waste stored: "+Amount);}
        public  Waste(string s){
            this.name = s;
        } 
    }
}
