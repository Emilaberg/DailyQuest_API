using System.ComponentModel.DataAnnotations;

namespace Shared.DbModels
{
    public class QuizModel
    {
        [Key]
        public int QuizId { get; set; }

        public string? QuizDescription { get; set; }

        public string? QuizChallenge { get; set; }
        public string? QuizName { get; set; }
        public string? ImageUrl { get; set; }
        public List<QuizQuestion> QuizQuestions
        { get; set; } = new();

    }
}
