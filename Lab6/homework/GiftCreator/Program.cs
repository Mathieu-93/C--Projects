using System;

namespace GiftCreator
{
    class Program
    {
        static void Main(string[] args)
        {
        var rootBox = new CompositeGift("RootBox", 0);
        var truckToy = new SingleGift("TruckToy", 289);
        var plainToy = new SingleGift("PlainToy", 587);
        rootBox.Add(truckToy);
        rootBox.Add(plainToy);
        var childBox = new CompositeGift("ChildBox", 0);
        var soldierToy = new SingleGift("SoldierToy", 200);
        childBox.Add(soldierToy);
        //rootBox.Add(childBox);
        rootBox.Show();
        Console.WriteLine($"Total price is: {rootBox.CalculateTotalPrice()}");
        IGiftOrder member =new MemberOrder(rootBox.Name,rootBox.Price);
        member = new PremiumOrderDecorator(member);
        System.Console.WriteLine($"Total price is: {member.Discount(rootBox)}\n");

        childBox.Show();
        IGiftOrder regular =new MemberOrder(childBox.Name,childBox.Price);
        regular = new PreOrderDecorator(regular);
        System.Console.WriteLine($"Total price is: {regular.Discount(childBox)}");

        }
    }
}
