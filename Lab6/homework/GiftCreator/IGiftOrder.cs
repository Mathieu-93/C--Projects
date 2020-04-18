using System;

namespace GiftCreator
{
	interface IGiftOrder
    {
        double Discount(CompositeGift gift);
    }

    class PreOrder: CompositeGift,IGiftOrder
    {
        public PreOrder(string name,int price): base(name,price){}
        public double Discount(CompositeGift gift){
            System.Console.WriteLine("Calculating the total price as Preorder");
            return gift.CalculateTotalPrice()*0.9;
        }
    }
    class MemberOrder: CompositeGift,IGiftOrder
    {
        public MemberOrder(string name,int price): base(name,price){}
        public double Discount(CompositeGift gift){
            System.Console.WriteLine("Calculating the total price as Member");
            return gift.CalculateTotalPrice()*0.8;
        }
    }
    class PremiumOrder: CompositeGift,IGiftOrder
    {
        public PremiumOrder(string name,int price): base(name,price){}
        public double Discount(CompositeGift gift){
            System.Console.WriteLine("Calculating the total price as Preorder");
            return gift.CalculateTotalPrice()*0.7;
        }
    }
    
}    