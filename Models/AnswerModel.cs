using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared;

public class AnswerModel
{
    [Key]
    public int AnswerId { get; set; }

    public required bool IsCorrect { get; set; }
    public QuestionModel? QuestionModel { get; set; }
    public int QuestionId { get; set; }
}

