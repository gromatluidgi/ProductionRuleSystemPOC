namespace ProductionRuleSystem.Domain
{
    public class Transaction
    {

        public Transaction(Customer customer, int amount)
        {
            Customer = customer;
            Amount = amount;
        }

        public Customer Customer { get; set; }
        public int Amount { get; set; }

        public TransactionState State { get; set; } = TransactionState.PENDING;

    }
}
