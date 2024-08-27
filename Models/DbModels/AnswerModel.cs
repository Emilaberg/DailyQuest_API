using System.ComponentModel.DataAnnotations;

namespace Shared.DbModels;

public class AnswerModel
{
    [Key]
    public int AnswerId { get; set; }

    public string Answer { get; set; }

    public required bool IsCorrect { get; set; }
    public QuestionModel? QuestionModel { get; set; }
    public int QuestionId { get; set; }
}

