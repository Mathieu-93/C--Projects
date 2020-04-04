using System;
using System.Collections.Generic;

namespace ProgramFactory
{
    abstract class VehicleFactory
    {
        public abstract Vehicle Create(string power_, int Vmax_);

    }
}