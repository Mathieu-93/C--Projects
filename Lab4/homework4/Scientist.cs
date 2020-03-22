using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class Scientist:Human
    {
        public Scientist(double s): base(s){}
        public ScientificProbe myProbe{get;set;}
        public void Work(){}
    }
}
