using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEx
{
    public class MyLogger
    {
        private static MyLogger instance = null;
        private MyLogger() { }
        public int X { get; set; }
        public static MyLogger GetMyLogger()
        {
            if(instance == null)
            {
                instance = new MyLogger();
            }
            return instance;
        }
    }
}
