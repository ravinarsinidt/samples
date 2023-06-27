using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsEx
{
    internal class AudreeExption : Exception
    {
        public readonly int AudreeData;

        public AudreeExption(string msg, int data):base(msg)
        {
            this.AudreeData = data;
        }
    }
}
