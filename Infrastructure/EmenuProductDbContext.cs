using BCM.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace EmenuProduct.Infrastructure
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

        public void SetCurrentStoreId(string StoreId)
        {
            _currentStoreName = StoreId;
        }

       
        public DbSet<CategoryEntity> Categories { get; set; }





        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
        

			return base.SaveChangesAsync(cancellationToken);
		}

        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }
    }

}

