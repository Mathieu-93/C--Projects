using System;
namespace Laptop
{
    class Asus: Laptop 
    {
        public override string ToString(){
            return "This is laptop with id: "+ID+"\nBrand: ASUS";
            
        }
        public override string Specification(){
            return "Screen: 14 cali, 1920 x 1080 pikseli \nProcessor:AMD® Ryzen 5 3500U 2,1 - 3,7 GHz \nMemory: 8 GB RAM \nSystem:Linux Ubuntu";
        }
        public new bool IsTurnOn{get;set;}
        public override void ConnectViaBle(){
            System.Console.WriteLine("Searching for device");
        }
        private string iD = "789GFS";
        public override string ID{
            get{return iD;}
        }
    }

}