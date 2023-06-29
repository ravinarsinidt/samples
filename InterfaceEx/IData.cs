using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    public interface IData
    {
        int Get(string key);
        int Update(string key, string value);
        int Delete(string key);
        void Save(string key, string value);        
    }
}
