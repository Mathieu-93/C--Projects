using System;

namespace Lab2
{
    class Scooter: Vehicle
    {
        public Scooter(string power_,int Vmax_)
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
            return "This is a scooter.\nPower: "+power+"\nVelocity limit:"+ Vmax+"km/h";
        }
    }
}