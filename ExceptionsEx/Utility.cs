using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsEx
{
    internal class Utility
    {
        public static bool IsInteger(string input)
        {
            try
            {
                int x = int.Parse(input);
                
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
