using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DbModels
{
    public class TicketModel
    {
        public required int Id { get; set; }
        public required string Email { get; set; }
        public required string Subject { get; set; }
        public required string Message { get; set; }
        public required DateTime TimeStamp { get; set; }
    }
}
