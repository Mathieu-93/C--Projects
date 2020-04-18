using System;

namespace GiftCreator
{
	class MemberOrderDecorator: Decorator
    {
        public MemberOrderDecorator(IGiftOrder order): base(order){}
        public override double Discount(CompositeGift gift)
        {
            Console.WriteLine($"Calculating the total price in a MemberOrderDecorator class");
            return base.Discount(gift)*0.8;
        }
    }
}