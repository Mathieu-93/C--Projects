using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	class TouristAttraction
    {
        public string Name{set;get;}
        public int timeSchedule{set;get;}
        public TouristAttraction(string name)
        {
            Name = name;
        }
        public void show() {
            Console.WriteLine($"Tickets reserved for the {Name}\n {timeSchedule}:00 visiting: {Name} .");
        }
    }
}