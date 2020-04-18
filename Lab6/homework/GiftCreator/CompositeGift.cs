using System;
using System.Collections.Generic;

namespace GiftCreator
{
    class CompositeGift : IGiftOperation
    {
        private List<IGiftOperation> _gift = new List<IGiftOperation>();
        private string name;
        public string Name{get;set;}
        private int price;
        public int Price{get;set;}
        public CompositeGift(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public void Add(IGiftOperation gift)
        {
            _gift.Add(gift);
        }

        public void Remove(IGiftOperation gift)
        {
            _gift.Remove(gift);
        }
        public void Show()
        {
            Console.WriteLine($"Present {name} contins:");
            foreach (var gift in _gift)
            {
                gift.Show();
            }
        }
        public  int CalculateTotalPrice()
        {
            int total = 0;

            foreach (var gift in _gift)
            {
                total += gift.CalculateTotalPrice();
            }

            return total;
        }

    }
}