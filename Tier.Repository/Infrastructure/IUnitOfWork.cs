namespace Tier.Repository.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}