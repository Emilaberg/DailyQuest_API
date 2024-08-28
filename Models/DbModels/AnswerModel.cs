using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.DbModels;

public class AnswerModel
{
    [Key]
    public int AnswerId { get; set; }

    public string Answer { get; set; } = null!;

    public required bool IsCorrect { get; set; }

    [ForeignKey(nameof(QuestionId))]
    public QuestionModel? QuestionModel { get; set; }

    public int QuestionId { get; set; }
}

