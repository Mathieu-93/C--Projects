using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    interface IStorable
    {
        double Amount{get;set;}
        void HowMuchLeft();
    }
}