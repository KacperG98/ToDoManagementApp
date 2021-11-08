using Domain.Common;
using Domain.Models;
using Infrastricture.Contexts.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace Infrastricture.Contexts
{
    class DefaultContext : DbContext, IDefaultContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tasks { get; init; }
        public DbSet<Organization> Organizations { get; init; }
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().OwnsOne(p => p.UserName);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Active = true;
                        break;
                    case EntityState.Modified:
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.ModifiedBy = string.Empty;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Active = false;
                        entry.Entity.DisactiveBy = string.Empty;
                        entry.State = EntityState.Modified;
                        break;

                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
