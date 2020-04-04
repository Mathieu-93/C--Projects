using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class ToyotaFactory : CarFactory
    {
        public override Car Create()
        {
            return new Audi("1.4 D-4D","Hatchback","Continental");
        }
    }
}