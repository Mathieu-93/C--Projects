using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    abstract class Human
    {
        static private double MedianSalary =1500;
        private Random random;
        public double Salary{get;set;}
        public int Breathe(){
            return 100;
        }
        public double Eat(){
            return random.NextDouble();
        }
        public Human(double s){
            random = new Random((int)DateTime.Now.Ticks);
        }

    }
}