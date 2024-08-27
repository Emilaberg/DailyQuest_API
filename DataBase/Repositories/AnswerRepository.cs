using DataBase.Repositories.Interfaces;
using Shared.DbModels;

namespace DataBase.Repositories
{
    public class AnswerRepository : GenericRepository<AnswerModel>, IAnswerRepository
    {
        public AnswerRepository(AppDbContext context) : base(context)
        {
        }

        // Implement any additional methods specific to Answer if needed
    }
}
