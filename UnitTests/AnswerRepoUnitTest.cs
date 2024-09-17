using DataBase.Repositories;
using Microsoft.EntityFrameworkCore;
using Shared.DbModels;
using System.Threading.Tasks;
using Xunit;
using UnitTests; 

namespace DataBase.UnitTests
{
    public class AnswerRepositoryTests
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public AnswerRepositoryTests()
        {
            // Setting up the in-memory database options for testing
            _options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
        }

        [Fact]
        public async Task GetByIdAsync_ExistingId_ReturnsCorrectAnswer()
        {
            // Arrange
            // Seed the in-memory database with a test answer
            using (var context = new AppDbContext(_options))
            {
                var testAnswer = new AnswerModel
                {
                    AnswerId = 1,
                    Answer = "Test Answer",
                    IsCorrect = true,
                    QuestionId = 1
                };

                context.Answers.Add(testAnswer);
                await context.SaveChangesAsync();
            }

            // Act
            // Create a new context instance to mimic real repository behavior
            using (var context = new AppDbContext(_options))
            {
                var repository = new AnswerRepository(context);
                var result = await repository.GetByIdAsync(1); // Trying to fetch the seeded answer

                // Assert
                Assert.NotNull(result);
                Assert.Equal(1, result.AnswerId);
                Assert.Equal("Test Answer", result.Answer);
                Assert.True(result.IsCorrect);
            }
        }

        [Fact]
        public async Task GetByIdAsync_NonExistingId_ReturnsNull()
        {
            // Act
            // Create a new context instance with no seeded data
            using (var context = new AppDbContext(_options))
            {
                var repository = new AnswerRepository(context);
                var result = await repository.GetByIdAsync(99); // Trying to fetch a non-existing answer

                // Assert
                Assert.Null(result);
            }
        }
    }
}