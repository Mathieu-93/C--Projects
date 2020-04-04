using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class BMWFactory : CarFactory
    {
        public override Car Create()
        {
            return new BMW("xDrive25d","combi","Michelin");
        }
    }
}