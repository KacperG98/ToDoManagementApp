using Domain.Models;
using Infrastricture.Contexts.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastricture.Contexts
{
    class TaskContext : DbContext, ITaskContext
    {
        public DbSet<TaskTicket> Tasks { get; init; }
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }
    }
}
