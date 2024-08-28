using System.ComponentModel.DataAnnotations;

namespace Shared.DbModels
{
    public class QuizModel
    {
        [Key]
        public int QuizId { get; set; }
        public string? QuizName { get; set; }
        public List<QuizQuestion> QuizQuestions { get; set; } = new();

    }
}
