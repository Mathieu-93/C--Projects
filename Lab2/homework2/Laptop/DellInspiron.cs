using System;
namespace Laptop
{
    class DellInspiron: Laptop 
    {
        public override string ToString(){
            return "This is laptop with id: "+ID+"\nBrand: DELL";
            
        }
        public override string Specification(){
            return "Screen: 15,6 cala, 1920 x 1080 pikseli \nProcessor:Intel Core i7 9gen 9750H 2,6 - 4,5 GHz \nMemory:16 GB RAM \nSystem:Windows";
        }
        public new bool IsTurnOn{get;set;}
        public override void ConnectViaBle(){
            System.Console.WriteLine("Searching for device");
        }
        private string iD="123DSA";
        public override string ID{
            get{return iD;}
        }

    }

}