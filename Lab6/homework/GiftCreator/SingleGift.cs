using System;

namespace GiftCreator
{
    class SingleGift:IGiftOperation
    {
        public string Gift { get; private set; }
        public int Price { get; private set; }
        public SingleGift(string g, int p)
        {
            Gift = g;
            Price = p;
        }
        public void Show()
        {
            Console.WriteLine(Gift + " (" + Price + " zł).");
        }
        public int CalculateTotalPrice()
        {
            return Price;
        }

    }
}