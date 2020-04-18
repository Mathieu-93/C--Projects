using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
	class PaymentCommand:ICommand
    {
        private readonly MethodOfPayment _methodOfPayment;
        private readonly string _payment;
        public PaymentCommand (MethodOfPayment methodOfPayment,string payment){
            _methodOfPayment = methodOfPayment;
            _payment = payment;
        }
        public double Price(){
            return 0;
        }
        public void Execute(){
            _methodOfPayment.Payment = _payment;
            _methodOfPayment.showPayment();
        }
    }
}