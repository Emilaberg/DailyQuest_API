using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Shared;

public class CategoryModel
{
    [Key]
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

}
