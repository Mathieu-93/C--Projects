using System;

namespace GiftCreator
{
	class PreOrderDecorator: Decorator
    {
        public PreOrderDecorator(IGiftOrder order): base(order){}
        public override double Discount(CompositeGift gift)
        {
            Console.WriteLine("Calculating the total price after adding Preorder disconut");
            return base.Discount(gift)*0.9;
        }
    }
}