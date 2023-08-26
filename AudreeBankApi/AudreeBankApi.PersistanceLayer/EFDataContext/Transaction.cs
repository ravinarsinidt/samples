namespace AudreeBankApi.PersistanceLayer.EFDataContext
{
    public class Transaction
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public decimal Amount { get; set; }       
    }
}
