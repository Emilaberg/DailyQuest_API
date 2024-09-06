using DataBase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.DbModels;

namespace DataBase.Repositories
{
    public class QuizRepository : GenericRepository<QuizModel>, IQuizRepository
    {
        public QuizRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<QuizModel?> GetByIdAsync_EagerLoading(int id)
        {
            return await _dbSet
                .Include(quiz => quiz.QuizQuestions)
                .ThenInclude(quizQuestion => quizQuestion.Question)
                .ThenInclude(question => question.Answers)
                .FirstOrDefaultAsync(quiz => quiz.QuizId == id);
        }
    }
}
