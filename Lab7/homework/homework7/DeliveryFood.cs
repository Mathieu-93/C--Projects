using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
	class DeliveryFood
    {
        private List<ICommand> OrderSet;
        private double totalSum = 0;
        public DeliveryFood()
        {
            OrderSet = new List<ICommand>();
        }
        public void Add(ICommand com)
        {
            OrderSet.Add(com);
        }
        public void Run()
        {
            
            foreach (ICommand com in OrderSet)
            {
                com.Execute();
                totalSum +=com.Price();
            }
            System.Console.WriteLine("Total sum of order: "+ totalSum+"PLN");
        }
    }
}