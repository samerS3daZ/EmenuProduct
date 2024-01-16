using BCM.Domain.Repositories;

namespace BCM.Domain.UnitOfWork
{
	public interface IUnitOfWork
	{
		
		ICategoryRepository CategoryRepository { get; }
		
        void Commit();
		void Rollback();
		Task CommitAsync();
		Task RollbackAsync();
	}
    
}

