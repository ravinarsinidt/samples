using DataModels = BankingEx.EFModels;
using BankingEx.ViewModels;

namespace BankingEx.Utilities
{
    public class DataMapper
    {
        public static DataModels.Customer CovertCustomerViewModelToEFModel(Customer customer)
        {
            DataModels.Customer result = new DataModels.Customer();

            result.Id = customer.Id.Value;
            result.Name = customer.Name;
            result.PanNumber = customer.PanNumber;
            result.Number = customer.Number;
            result.Dob = customer.Dob.Value;
            result.City = customer.City;    

            return result;
        }
    }
}
