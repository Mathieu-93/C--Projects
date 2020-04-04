using System;
using System.Collections.Generic;

namespace ProgramFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            // C2 
            // List<Vehicle> myTransport = new List<Vehicle>();
            // myTransport.Add(new Train("Electric", 90));
            // myTransport.Add(new Car("Hybrid", 120));
            // foreach (Vehicle v in myTransport)
            // {
            //     Console.WriteLine(v);
            // }

            // C5 zadanie 1
            List<VehicleFactory> myFactories = new List<VehicleFactory>();
            myFactories.Add(new TrainFactory());
            myFactories.Add(new CarFactory());
            // tu moga dziac sie rozne rzeczy
            foreach(VehicleFactory factory in myFactories)
            {
                Vehicle v = factory.Create("Generic",100);
                Console.WriteLine(v);
            }

            
            // C5 zadanie 2
            List<Vehicle> myTransport = new List<Vehicle>();
            CityTransportFactory myFactory = new CityTransportFactory();
            // chce dojechac na miejsce jak najszybciej, niewazne jakim srodkiem transportu
            myTransport.Add(myFactory.CreateFastest());
            // nie spieszy mi sie, tym razem wole jechac jak najmniejszym kosztem
            myTransport.Add(myFactory.CreateCheapest());
            // poprosze dowolny srodek transportu publicznego
            myTransport.Add(myFactory.CreatePublic());
            // czasami wiem dokladnie czego chce i moge podac parametry
            myTransport.Add(myFactory.Create("Car",50));
            // moge tez zazadac pojazdu ktorego jeszcze nie da sie wyprodukowac, ale moze wkrotce programista go dokodzi
            // w takim wypadku fabryka bedzie tymczasowo zwracala null, dzieki czemu nie zepsuje reszty kodu
            myTransport.Add(myFactory.Create("Flying Car",50));
            // i potencjalnie wiele innych mozliwosci
            foreach (Vehicle v in myTransport) Console.WriteLine(v+"\n");
            

        }
    }
}
