using System;

namespace GiftCreator
{
    class MoneyFrom: IGiftOperation
    {
        
        public string Name { get; private set; }
        public int Cash { get; private set; }
        public MoneyFrom(string n, int c)
        {
            Name = n;
            Cash = c;
        }
        public void Show()
        {
            Console.WriteLine(Name + " gives" + Cash + " zł in cash");
        }
        public int CalculateTotalPrice()
        {
            return Cash;
        }
        
    }
}
