using System;
using DataBase.Repositories;
using Microsoft.EntityFrameworkCore;
using Shared.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DataBase.Tests
{
    public class QuizRepositoryTests
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public QuizRepositoryTests()
        {
            // Setting up the in-memory database options for testing
            _options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestQuizDatabase")
                .Options;
        }

        [Fact]
        public async Task GetAllAsync_ReturnsAllQuizzes()
        {
            // Arrange
            // Seed the in-memory database with test quizzes
            using (var context = new AppDbContext(_options))
            {
                var testQuizzes = new List<QuizModel>
                {
                    new QuizModel
                    {
                        QuizId = 1,
                        QuizName = "Quiz 1",
                        QuizDescription = "Description 1",
                        QuizChallenge = "Challenge 1",
                        ImageUrl = "http://example.com/image1.png"
                    },
                    new QuizModel
                    {
                        QuizId = 2,
                        QuizName = "Quiz 2",
                        QuizDescription = "Description 2",
                        QuizChallenge = "Challenge 2",
                        ImageUrl = "http://example.com/image2.png"
                    },
                    new QuizModel
                    {
                        QuizId = 3,
                        QuizName = "Quiz 3",
                        QuizDescription = "Description 3",
                        QuizChallenge = "Challenge 3",
                        ImageUrl = "http://example.com/image3.png"
                    }
                };

                context.Quizzes.AddRange(testQuizzes);
                await context.SaveChangesAsync();
            }

            // Act
            // Create a new context instance to mimic real repository behavior
            using (var context = new AppDbContext(_options))
            {
                var repository = new QuizRepository(context);
                var result = await repository.GetAllAsync(); // Fetching all quizzes

                // Assert
                Assert.NotNull(result);
                Assert.Equal(3, result.Count()); // Ensure three quizzes are returned

                // Check that the specific quizzes are correctly returned with their properties
                Assert.Contains(result, quiz =>
                    quiz.QuizName == "Quiz 1" &&
                    quiz.QuizDescription == "Description 1" &&
                    quiz.QuizChallenge == "Challenge 1" &&
                    quiz.ImageUrl == "http://example.com/image1.png"
                );

                Assert.Contains(result, quiz =>
                    quiz.QuizName == "Quiz 2" &&
                    quiz.QuizDescription == "Description 2" &&
                    quiz.QuizChallenge == "Challenge 2" &&
                    quiz.ImageUrl == "http://example.com/image2.png"
                );

                Assert.Contains(result, quiz =>
                    quiz.QuizName == "Quiz 3" &&
                    quiz.QuizDescription == "Description 3" &&
                    quiz.QuizChallenge == "Challenge 3" &&
                    quiz.ImageUrl == "http://example.com/image3.png"
                );
            }
        }
    }
}