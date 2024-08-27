using System.ComponentModel.DataAnnotations;

namespace Shared.DbModels;

public class MetaTagModel
{
    [Key]
    public int MetaTagId { get; set; }

    public string? TagName { get; set; }

    public List<QuestionMetaTag> QuestionMetaTags { get; set; } = new List<QuestionMetaTag>();
}

