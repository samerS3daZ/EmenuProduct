using BCM.Domain.Entities;
using BCM.Domain.UnitOfWork;
using BCM.Infrastructure;
using BCM.Infrastructure.Contracts;
using BCM.Infrastructure.CustomServices;
using BCM.Infrastructure.Dtos;
using BCM.Infrastructure.Dtos.CategoriesDto;
using BCM.Infrastructure.Helpers;

namespace BCM.Infrastructure.Services
{
    public class CategoryService : ICategoryService
	{
		public IUnitOfWork _unitOfWork;
		private readonly IUploadFileService _uploadFileService;
		

		public CategoryService(IUnitOfWork unitOfWork,
			IUploadFileService uploadFileService)
		{
			_unitOfWork = unitOfWork;
		
			_uploadFileService = uploadFileService;
		}


    }
}
