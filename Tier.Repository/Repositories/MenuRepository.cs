using Tier.Model.Models;
using Tier.Repository.Infrastructure;

namespace Tier.Repository.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {

    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}