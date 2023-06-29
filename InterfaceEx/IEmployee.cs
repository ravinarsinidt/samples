using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    internal interface IEmployee : IData
    {
        public int GetByValue(int value);
    }
}
