using Domain.Enums;
using System;

namespace Domain.Models
{
    public class TaskTicket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime ExecutionTime { get; set; }
        public TaskStatus Status { get; set; }
    }
}
