using ChainofResponsibility.Infrastructure;

namespace ChainofResponsibility.Implementation
{
    internal class Manager : IApprover
    {
        private readonly IApprover _nextApprover;

        public Manager(IApprover nextApprover)
        {
            _nextApprover = nextApprover;
        }

        public void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount <= 1000)
            {
                Console.WriteLine($"Manager approved the purchase of ${purchase.Amount}");
            }
            else
            {
                _nextApprover.ProcessRequest(purchase);
            }
        }
    }
}