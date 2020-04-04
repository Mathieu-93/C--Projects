using System;

namespace Homework
{
    class CarForRealDrivers:ICarAdvisorFactory
    {
        public Car CereateTheBestEngine() =>new BMW("4.4liter V8","sedan","Michelin");
        public Car CereateFlexibleBody() =>new Audi("45 TDI quattro","SUV","Continental");
        public Car CreateTyreWithMoreTraction() => new Audi("4.0 TFSI V8","sedan","Pirelli P Zero");
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