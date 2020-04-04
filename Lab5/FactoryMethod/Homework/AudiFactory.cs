using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class AudiFactory : CarFactory
    {
        public override Car Create()
        {
            return new Audi("4.0 TFSI V8","sedan","Pirelli P Zero");
        }
    }
}