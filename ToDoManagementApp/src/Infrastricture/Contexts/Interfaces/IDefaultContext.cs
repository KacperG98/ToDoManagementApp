using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastricture.Contexts.Interfaces
{
    interface IDefaultContext
    {
        DbSet<Ticket> Tasks { get; }
    }
}
