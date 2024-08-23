using DataBase.Repositories.Interfaces;
using Shared.DbModels;

namespace DataBase.Repositories
{
    public class MetaTagRepository : GenericRepository<MetaTagModel>, IMetaTagRepository
    {
        public MetaTagRepository(AppDbContext context) : base(context)
        {
        }

    }
}
