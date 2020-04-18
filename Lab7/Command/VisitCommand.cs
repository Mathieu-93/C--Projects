using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	class VisitCommand:ICommand
    {
        private readonly TouristAttraction touristAttraction;
        private readonly int time;
        public VisitCommand(TouristAttraction attraction,int t){
            touristAttraction = attraction;
            time =t;
        }
        public void Execute(){
            touristAttraction.timeSchedule = time;
            touristAttraction.show();
        }
    }
}
