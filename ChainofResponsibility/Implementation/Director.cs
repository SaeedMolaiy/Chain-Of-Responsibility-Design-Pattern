using ChainofResponsibility.Infrastructure;

namespace ChainofResponsibility.Implementation
{
    internal class Director : IApprover
    {
        private readonly IApprover _nextApprover;

        public Director(IApprover nextApprover)
        {
            _nextApprover = nextApprover;
        }

        public void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount <= 5000)
            {
                Console.WriteLine($"Director approved the purchase of ${purchase.Amount}");
            }
            else
            {
                _nextApprover.ProcessRequest(purchase);
            }
        }
    }
}