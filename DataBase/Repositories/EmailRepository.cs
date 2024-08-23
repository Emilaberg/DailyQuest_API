using DataBase.Repositories.Interfaces;
using Shared.DbModels;

namespace DataBase.Repositories
{
    public class EmailRepository : GenericRepository<EmailModel>, IEmailRepository
    {
        public EmailRepository(AppDbContext context) : base(context)
        {
        }

        // Implement any additional methods specific to Email if needed
    }
}
