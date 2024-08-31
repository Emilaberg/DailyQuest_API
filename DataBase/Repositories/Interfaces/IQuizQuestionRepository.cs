using Shared.DbModels;

namespace DataBase.Repositories.Interfaces
{
    public interface IQuizQuestionRepository : IGenericRepository<QuizQuestion>
    {
        Task DeleteAsync(object compositeKey);
        Task<QuizQuestion> GetByQuizAndQuestionIdAsync(int quizId, int questionId);
    }
}
