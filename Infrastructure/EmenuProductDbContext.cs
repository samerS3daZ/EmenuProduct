using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BCM.Domain.Entities;

namespace Infrastructure
{
    public class EmenuProductDbContext : IdentityDbContext
    {
        private string _currentUserName;
        private string _currentStoreName;

        public EmenuProductDbContext()
        {
        }

        public EmenuProductDbContext(DbContextOptions<EmenuProductDbContext> options)
            : base(options)
        {
        }

        public void SetCurrentUser(string userName)
        {
            _currentUserName = userName;
        }

        public void SetCurrentStoreId(string storeId)
        {
            _currentStoreName = storeId;
        }
        public DbSet<CategoryEntity> Categories { get; set; }
     


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries().Where(E => E.State == EntityState.Added || E.State == EntityState.Modified).ToList();
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Customize your configuration here if needed
            base.OnConfiguring(optionsBuilder);
        }
    }
}
