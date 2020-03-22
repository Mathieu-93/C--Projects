using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Train("Electiric",90);
            myVehicle.ShowData();
            System.Console.WriteLine(myVehicle.ToString());


            List <Vehicle> myTransport = new List<Vehicle>();
            myTransport.Add(new Train("Electric", 90));
            myTransport.Add(new Car("Hybrid", 120));
            foreach(Vehicle v in myTransport) Console.WriteLine(v);
        }
    }
}
