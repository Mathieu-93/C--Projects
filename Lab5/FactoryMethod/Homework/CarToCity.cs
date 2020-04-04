using System;

namespace Homework
{
    class CarToCity:ICarAdvisorFactory
    {
        public Car CereateTheBestEngine() =>new BMW("i3","Hatchback","Michelin");
        public Car CereateFlexibleBody() =>new Toyota("1.4 D-4D","Hatchback","Continental");
        public Car CreateTyreWithMoreTraction() => new Audi("quattro S3","Hatchback","Dunlop");

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