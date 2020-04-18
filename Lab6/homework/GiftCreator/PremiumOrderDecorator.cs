using System;

namespace GiftCreator
{
	class PremiumOrderDecorator: Decorator
    {
        public PremiumOrderDecorator(IGiftOrder order): base(order){}
        public override double Discount(CompositeGift gift)
        {
            Console.WriteLine("Calculating the total price after adding Premium disconut");
            return base.Discount(gift)*0.7;
        }
    }
}