using System;
using System.Collections.Generic;

namespace ProgramFactory
{
     class CityTransportFactory
    {
        public Vehicle CreateFastest() =>new Metro();
        public Vehicle CreateCheapest() => new Bicycle();
        public Vehicle CreatePublic() => new Bus();
        public Vehicle Create(string power_,int Vmax_) => new Car(power_, Vmax_); 
    }
}