using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Shared;

public class MetaTagModel
{
    [Key]
    public int MetaTagId { get; set; }

    public string TagName { get; set; }

    public List<QuestionMetaTag> QuestionMetaTags { get; set; } = new List<QuestionMetaTag>();
}

