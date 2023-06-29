using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    internal class EmployeeAccount : IAccountData, IEmployee
    {
        public int Delete(string key)
        {
            throw new NotImplementedException();
        }

        public int Get(string key)
        {
            throw new NotImplementedException();
        }

        public int GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public int GetByValue(int value)
        {
            throw new NotImplementedException();
        }

        public void Save(string key, string value)
        {
            throw new NotImplementedException();
        }

        public int Update(string key, string value)
        {
            throw new NotImplementedException();
        }
    }
}
