using System.ComponentModel.DataAnnotations;

namespace Shared.DbModels
{
    public class EmailModel
    {


        [Key]
        public int EmailId { get; set; }

        public required string Email { get; set; }

        public DateTime DateLastSent { get; set; }

    }
}
