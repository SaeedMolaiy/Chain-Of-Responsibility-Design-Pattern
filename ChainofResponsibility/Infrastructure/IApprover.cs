namespace ChainofResponsibility.Infrastructure
{
    internal interface IApprover
    {
        void ProcessRequest(Purchase purchase);
    }
}