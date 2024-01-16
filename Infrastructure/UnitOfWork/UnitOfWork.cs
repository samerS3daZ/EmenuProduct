using BCM.Domain.Repositories;
using BCM.Domain.UnitOfWork;
using BCM.Infrastructure.Helpers;
using BCM.Infrastructure.Repositories;
using Infrastructure;
using System.Security.Claims;

namespace BCM.Infrastructure.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
        private readonly EmenuProductDbContext _dbContext;
		private ICategoryRepository _categoryRepository;
		
		public UnitOfWork(EmenuProductDbContext dbContext)
		{
			_dbContext = dbContext;
        }

      
		


		public ICategoryRepository CategoryRepository
		{
			get { return _categoryRepository ??= new CategoryRepository(_dbContext); }
		}

		public void Commit()
			=> _dbContext.SaveChanges();

		public async Task CommitAsync()
			=> await _dbContext.SaveChangesAsync();

		public void Rollback()
			=> _dbContext.Dispose();

		public async Task RollbackAsync()
			=> await _dbContext.DisposeAsync();
	}
}

