using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class TripPlanAdapter: IJurneyPlan
    {
        private TripPlan _tripPlan = new TripPlan();
        public void Run(List<ICommand> items){
            foreach(var item in items){
                _tripPlan.Add(item);
                item.Execute();
            }

        }
    }
}