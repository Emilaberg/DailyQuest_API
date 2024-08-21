using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared;

public class QuestionModel
{
    [Key]
    public int QuestionId { get; set; }


    public CategoryModel? Category { get; set; }

    public int CategoryId { get; set; }


    public required string CategoryName { get; set; } = null!;


}
