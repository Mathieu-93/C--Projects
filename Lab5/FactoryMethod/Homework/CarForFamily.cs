using System;

namespace Homework
{
    class CarForFamily:ICarAdvisorFactory
    {
        public Car CereateTheBestEngine() =>new BMW("xDrive25d","combi","Michelin");
        public Car CereateFlexibleBody() =>new Toyota("1.5 C-4D","minivan","Continental");
        public Car CreateTyreWithMoreTraction() => new Audi("3.0 TDI","combi","Pirelli P Zero");

        public Car DreamCar(string s, string eng){
            if(s =="Audi"){
                return new Audi(eng,"Sedan","Continental");
            }else if(s =="BMW"){
                return new BMW(eng,"Sedan","Michelin");
            }else if(s =="Toyota"){
                return new Toyota(eng, "Combi", "Michelin");
            }
            return null;
        }
    }
}