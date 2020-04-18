using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
	class MethodOfPayment
    {
        public string Payment{set;get;}
        public void showPayment() {
            System.Console.WriteLine( $"Customer will pay by {Payment}");
        }
    }
}