using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    interface IFastOrder
    {
        void Run(List<ICommand> items);
    }
}