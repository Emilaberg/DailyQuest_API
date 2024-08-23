using DataBase.Repositories.Interfaces;
using Shared.DbModels;

namespace DataBase.Repositories
{
    public class QuizRepository : GenericRepository<QuizModel>, IQuizRepository
    {
        public QuizRepository(AppDbContext context) : base(context)
        {
        }
    }
}
