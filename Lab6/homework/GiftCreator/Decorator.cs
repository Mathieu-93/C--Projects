using System;

namespace GiftCreator
{
	abstract class Decorator:  IGiftOrder
    {
        protected IGiftOrder order ;
        public Decorator(IGiftOrder order){
            this.order = order;
        }
        public virtual double Discount(CompositeGift gift)
        {
            Console.WriteLine($"Calculating the total price in a decorator class");
            return order.Discount(gift);
        }
    }
}