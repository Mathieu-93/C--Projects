using System;

namespace Lab2
{
    class Car:Vehicle
    {
        public Car(string power_,int Vmax_)
        {
            power = power_;
            Vmax = Vmax_;
        }
        public override void ShowData(){
            System.Console.WriteLine("Vehicle type: train");
        }
        public string power{get;set;}
        public int Vmax{get;set;}

        public override string ToString(){
            return "This is a car.\nPower: "+power+"\nVelocity limit:"+ Vmax+"km/h";
        }
    }
}