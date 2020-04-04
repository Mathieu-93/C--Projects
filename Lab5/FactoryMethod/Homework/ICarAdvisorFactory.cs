using System;

namespace Homework
{
    interface ICarAdvisorFactory
    {
        Car CereateTheBestEngine();
        Car CereateFlexibleBody();
        Car CreateTyreWithMoreTraction();
        Car DreamCar(string s,string eng);
    }
}