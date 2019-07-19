using Tier.Repository;

namespace Tier.Repository.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DataSoure_DbContext dbContext;

        public DataSoure_DbContext Init()
        {
            return dbContext ?? (dbContext = new DataSoure_DbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}