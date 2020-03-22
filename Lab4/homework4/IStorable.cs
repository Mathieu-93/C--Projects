using System;
using System.Collections.Generic;
using System.Text;

namespace C4
{
    interface IStorable
    {
        double Amount{get;set;}
        void HowMuchLeft();
    }
}