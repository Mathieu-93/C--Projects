using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerChoice pizza = new CustomerChoice("Capriciosa");
            CustomerChoice pasta = new CustomerChoice("Spaghetti");
            CustomerChoice drink = new CustomerChoice("Cola");
            MethodOfPayment byCash =new MethodOfPayment();
            MethodOfPayment byCreditCard =new MethodOfPayment();

            OrderCommand orderPizza = new OrderCommand(pizza,20);
            GetDiscountCommand orderdrink = new GetDiscountCommand(drink,6);
            PaymentCommand payByCash = new PaymentCommand(byCash ,"Cash");

            DeliveryFood firstOrder =new DeliveryFood();
            firstOrder.Add(orderPizza);
            firstOrder.Add(orderdrink);
            firstOrder.Add(payByCash);
            firstOrder.Run();

            DeliveryFoodAdapter OrderAdapter =new DeliveryFoodAdapter();
            OrderAdapter.Run(new List<ICommand>() {orderPizza,orderdrink,payByCash});
        }
    }
}
