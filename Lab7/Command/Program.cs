using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            TouristAttraction schonburn = new TouristAttraction("schonburn");
            TouristAttraction museum = new TouristAttraction("museum");
            VisitCommand visitSchonburn = new VisitCommand(schonburn,11);
            VisitCommand visitmuseum =new VisitCommand(museum,19);
            TripPlan planA =new TripPlan();
            planA.Add(visitSchonburn);
            //planA.Run();
            TripPlanAdapter tpa =new TripPlanAdapter();
            tpa.Run(new List<ICommand>() {visitSchonburn,visitmuseum});
        }
    }
}
