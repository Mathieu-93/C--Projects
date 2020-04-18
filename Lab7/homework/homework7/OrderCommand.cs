using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
	class OrderCommand:ICommand
    {
        private readonly CustomerChoice _customerChoice;
        private readonly int _price;
        public OrderCommand (CustomerChoice customerChoice,int price){
            _customerChoice = customerChoice;
            _price = price;
        }
        public double Price(){
            return _price;
        }
        public void Execute(){
            _customerChoice.Price = _price;
            _customerChoice.show();
        }
    }
}