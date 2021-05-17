using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Productum.Core.Model;

namespace Productum.Persistence
{
    public class ProductumContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductumContext(DbContextOptions<ProductumContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        protected  override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public  override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var AddedEntitties = ChangeTracker.Entries().Where(e => e.State == EntityState.Added).ToList();
            AddedEntitties.ForEach(e =>
            {
                e.Property("CreatedAt").CurrentValue = DateTime.Now;
            });

            var EditedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified).ToList();
            EditedEntities.ForEach(e =>
            {
                e.Property("ModifiedAt").CurrentValue = DateTime.Now;
            });
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override int  SaveChanges(bool acceptAllChangesOnSuccess)
        {
            var AddedEntitties = ChangeTracker.Entries().Where(e => e.State == EntityState.Added).ToList();
            AddedEntitties.ForEach(e =>
            {
                e.Property("CreatedAt").CurrentValue = DateTime.Now;
            });

            var EditedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified).ToList();
            EditedEntities.ForEach(e =>
            {
                e.Property("ModifiedAt").CurrentValue = DateTime.Now;
            });
            return  base.SaveChanges(acceptAllChangesOnSuccess);
        }
    }
}
