using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CarFactory> myFactories = new List<CarFactory>();
            myFactories.Add(new AudiFactory());
            myFactories.Add(new BMWFactory());
            // tu moga dziac sie rozne rzeczy
            foreach (CarFactory factory in myFactories)
            {
                Car v = factory.Create();
                Console.WriteLine(v.ShowParameters());
                Console.WriteLine();
            }

            List<Car> myAdvisor = new List<Car>();
            CarForFamily myFactory = new CarForFamily();

            List<Car> myAdvisor2 = new List<Car>();
            CarForRealDrivers myFactory2 = new CarForRealDrivers();
            
            myAdvisor.Add(myFactory.CereateTheBestEngine());
            myAdvisor.Add(myFactory.CreateTyreWithMoreTraction());
            
            myAdvisor.Add(myFactory.DreamCar("Audi","45 TDI quattro"));
            System.Console.WriteLine("Car for Family\n");
            foreach (Car v in myAdvisor) Console.WriteLine(v.ShowParameters()+"\n");

            myAdvisor2.Add(myFactory2.CereateTheBestEngine());
            myAdvisor2.Add(myFactory2.CreateTyreWithMoreTraction());

            myAdvisor2.Add(myFactory2.DreamCar("BMW","4.4liter V8"));
            System.Console.WriteLine("Car for real drivers\n");
            foreach (Car v in myAdvisor2) Console.WriteLine(v.ShowParameters()+"\n");

        }
    }
}
