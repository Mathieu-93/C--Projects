using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
	class GetDiscountCommand:ICommand
    {
        private readonly CustomerChoice _customerChoice;
        private readonly double _price;
        public GetDiscountCommand (CustomerChoice customerChoice,int price){
            _customerChoice = customerChoice;
            _price = price;
        }
        public double Price(){
            return _price*0.9;
        }
        public void Execute(){
            _customerChoice.Price = _price*0.9;
            System.Console.WriteLine("Price after discount");
            _customerChoice.show();
        }
    }
}