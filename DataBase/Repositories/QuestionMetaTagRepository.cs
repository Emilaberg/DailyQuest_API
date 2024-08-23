using DataBase.Repositories.Interfaces;
using Shared.DbModels;

namespace DataBase.Repositories
{
    public class QuestionMetaTagRepository : GenericRepository<QuestionMetaTag>, IQuestionMetaTagRepository
    {
        public QuestionMetaTagRepository(AppDbContext context) : base(context)
        {
        }
    }
}
