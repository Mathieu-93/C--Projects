using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    class DeliveryFoodAdapter: IFastOrder
    {
        private DeliveryFood _tripPlan = new DeliveryFood();
        private double totalSum =0;
        public void Run(List<ICommand> items){
            foreach(var item in items){
                _tripPlan.Add(item);
                item.Execute();
                totalSum +=item.Price();
            }
            System.Console.WriteLine("Total sum of order: "+ totalSum+"PLN");
        }

    }
}