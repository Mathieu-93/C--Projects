using System;
namespace Laptop
{
    class MacBook: Laptop 
    {
        public override string ToString(){
            return "This is laptop with id: "+ID+"\nBrand: APPLE";
            
        }
        public override string Specification(){
            return "Screen: 12,1 cala, 2304 x 1440 pikseli \nProcessor:Intel Core M-series 7Y32 1,2 - 3,0 GHz \nMemory:8 GB RAM \nSystem:MAC OS X";
        }
        public new bool IsTurnOn{get;set;}
        public override void ConnectViaBle(){
            System.Console.WriteLine("Functionality not available");
        }

        private string iD = "QWER123";
        public override string ID{
            get{return iD;}
        }
        
    }

}