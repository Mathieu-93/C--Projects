using System;
using System.Collections.Generic;

namespace ProgramFactory
{
    class TrainFactory: VehicleFactory
    {
        public override Vehicle Create(string power_,int Vmax_) => new Train(power_, Vmax_);
    }
}