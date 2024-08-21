using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DbModels
{
    internal class EmailModel
    {


        [Key]
        public int EmailId { get; set; }

        public required string Email { get; set; }

        public DateTime DateLastSent { get; set; }

    }
}
