using System;

namespace AudreeBankApi.PersistanceLayer.EFDataContext
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string City { get; set; }
    }
}
