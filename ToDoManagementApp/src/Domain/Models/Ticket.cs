using Domain.Common;
using Domain.Enums;
using System;

namespace Domain.Models
{
    public class Ticket : AuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ExecutionTime { get; set; }
        public TaskStatus Status { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
