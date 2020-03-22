using System;

namespace Laptop //1.
{
    abstract class Laptop: IFunctionality,IDeviceSpecification
    {
        public abstract string Specification();
        public  bool IsTurnOn{set;get;}
        public virtual void ConnectViaBle(){
            System.Console.WriteLine("Does not detected");
        }
        public abstract string ID{get;}

    }
    
}