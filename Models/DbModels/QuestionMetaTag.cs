using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DbModels;

public class QuestionMetaTag
{
    public int QuestionId { get; set; }
    public QuestionModel Question { get; set; }

    public int MetaTagId { get; set; }
    public MetaTagModel MetaTag { get; set; }
}

