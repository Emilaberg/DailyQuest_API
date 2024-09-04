using System.ComponentModel.DataAnnotations;

namespace Shared.DbModels;

public class QuestionModel
{
    [Key]
    public int QuestionId { get; set; }

    public string Question { get; set; } = null!;
    public string? Image { get; set; }

    public List<AnswerModel> Answers { get; set; } = new();

    public List<QuestionMetaTag> QuestionMetaTags { get; set; } = new();
    public List<QuizQuestion> QuizQuestions { get; set; } = new();

}
