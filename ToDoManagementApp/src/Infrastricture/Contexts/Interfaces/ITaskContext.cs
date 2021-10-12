using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastricture.Contexts.Interfaces
{
    interface ITaskContext
    {
        DbSet<TaskTicket> Tasks { get; }

    }
}
