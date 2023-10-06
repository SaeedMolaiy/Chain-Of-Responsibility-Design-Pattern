namespace ChainofResponsibility
{
    internal class Purchase
    {
        public string ProductName { get; }

        public double Amount { get; }

        public Purchase(string productName, double amount)
        {
            ProductName = productName;
            Amount = amount;
        }
    }
}