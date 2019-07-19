using System;

namespace Tier.Repository.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        DataSoure_DbContext Init();
    }
}