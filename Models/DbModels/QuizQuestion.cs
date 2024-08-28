using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DbModels;

public class QuizQuestion
{
    public int QuizId { get; set; }
    public QuizModel Quiz { get; set; }

    public int QuestionId { get; set; }
    public QuestionModel Question { get; set; }
}

