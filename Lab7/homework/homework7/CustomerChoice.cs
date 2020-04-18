using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
	class CustomerChoice
    {
        public string Name{set;get;}
        public double Price{set;get;}
        public CustomerChoice(string name)
        {
            Name = name;
        }
        public void show() {
            Console.WriteLine($"Current price for the {Name} product is {Price}PLN.");
        }
    }
}