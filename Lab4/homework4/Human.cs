using System;
using System.Collections.Generic;
using System.Text;

namespace C4
{
    abstract class Human
    {
        static private double MedianSalary;
        private Random random;
        public double Salary{get;set;}
        public int Breathe(){}
        public double Eat(){
            return random.NextDouble();
        }
        public Human(double s){
            random = new Random((int)DateTime.Now.Ticks);
        }

    }
}