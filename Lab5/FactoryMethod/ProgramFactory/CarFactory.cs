using System;
using System.Collections.Generic;

namespace ProgramFactory
{
     class CarFactory: VehicleFactory
    {
        public override Vehicle Create(string power_,int Vmax_) => new Car(power_,Vmax_);
        
    }
}
