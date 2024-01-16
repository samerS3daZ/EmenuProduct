using BCM.Infrastructure;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BCM.Infrastructure.Dtos.CategoriesDto
{
    public class CategoryAddUpdateDto 
    {
        
		public string? Name { get; set; }
       
		public string? Description { get; set; }
        public IFormFile? UploadedFile { get; set; }
        public string? Image { get; set; }
        public Guid? ParentId { get; set; }

    }
}
