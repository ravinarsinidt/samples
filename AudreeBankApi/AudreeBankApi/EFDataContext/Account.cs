namespace AudreeBankApi.EFDataContext
{
    public class Account
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public string Type { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
