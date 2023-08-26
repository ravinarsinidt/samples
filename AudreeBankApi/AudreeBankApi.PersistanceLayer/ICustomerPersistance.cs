using AudreeBankApi.PersistanceLayer.EFDataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudreeBankApi.PersistanceLayer
{
    public interface ICustomerPersistance
    {
        public bool Create(Customer customer);
        public List<Customer> Get();
    }
}
