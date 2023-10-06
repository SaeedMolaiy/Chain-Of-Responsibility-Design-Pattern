using ChainofResponsibility.Infrastructure;

namespace ChainofResponsibility.Implementation
{
    internal class Ceo : IApprover
    {
        public void ProcessRequest(Purchase purchase)
        {
            Console.WriteLine(purchase.Amount <= 10000
                ? $"CEO approved the purchase of ${purchase.Amount}"
                : "The purchase request cannot be approved.");
        }
    }
}