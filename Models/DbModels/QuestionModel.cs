using System.ComponentModel.DataAnnotations;

namespace Shared.DbModels;

public class QuestionModel
{
    [Key]
    public int QuestionId { get; set; }

    public int QuizModelId { get; set; }

    public string? Question { get; set; }
    //public int MetaTagId { get; set; }

    //public int QuizId { get; set; }

    public List<QuestionMetaTag> QuestionMetaTags { get; set; } = new();

    public List<AnswerModel> Answers { get; set; } = new();

    //public List<MetaTagModel> MetaTags { get; set; } = new();

    public List<QuizModel> QuizModels { get; set; } = new();

    //public required string CategoryName { get; set; } = null!;
}
