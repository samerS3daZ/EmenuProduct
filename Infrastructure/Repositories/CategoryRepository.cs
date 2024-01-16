using BCM.Domain.Entities;
using BCM.Domain.Repositories;
using Infrastructure;
using System.Linq.Expressions;

namespace BCM.Infrastructure.Repositories
{
	public class CategoryRepository : GenericRepository<CategoryEntity>, ICategoryRepository
	{
		public CategoryRepository(EmenuProductDbContext dbContext) : base(dbContext)
		{
		}
    }
}
