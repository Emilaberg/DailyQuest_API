using DataBase.Repositories.Interfaces;
using Shared.DbModels;

namespace DataBase.Repositories
{
    public class QuestionRepository : GenericRepository<QuestionModel>, IQuestionRepository
    {
        public QuestionRepository(AppDbContext context) : base(context)
        {
        }

        // Implement any additional methods specific to Question if needed
    }
}
