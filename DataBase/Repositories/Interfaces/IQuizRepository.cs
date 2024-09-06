using Shared.DbModels;

namespace DataBase.Repositories.Interfaces
{
    public interface IQuizRepository : IGenericRepository<QuizModel>
    {
        Task<QuizModel?> GetByIdAsync_EagerLoading(int id);
    }
}
