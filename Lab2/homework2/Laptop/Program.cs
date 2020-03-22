using System;
using System.Collections.Generic;


namespace Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop myLaptop = new Asus();
            myLaptop.ConnectViaBle();
            myLaptop.IsTurnOn = true;
            Console.WriteLine(myLaptop.Specification());
            //Console.WriteLine(myLaptop.ID);
            IFunctionality myLaptop1 = new Asus();
            myLaptop1.ConnectViaBle();

            List <Laptop> myLaptops = new List<Laptop>();
            myLaptops.Add(new DellInspiron());
            myLaptops.Add(new Asus());
            myLaptops.Add(new MacBook());

            foreach(Laptop l in myLaptops) Console.WriteLine(l);

        }
    }
}
