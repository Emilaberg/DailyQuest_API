using DataBase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.DbModels;

namespace DataBase.Repositories
{
    public class QuizQuestionRepository : GenericRepository<QuizQuestion>, IQuizQuestionRepository
    {
        public QuizQuestionRepository(AppDbContext context) : base(context)
        {
        }

        public Task DeleteAsync(object compositeKey)
        {
            throw new NotImplementedException();
        }

        public async Task<QuizQuestion> GetByQuizAndQuestionIdAsync(int quizId, int questionId)
        {
            return await _dbSet.FirstOrDefaultAsync(q => q.QuizId == quizId && q.QuestionId == questionId);
        }
    }
}
