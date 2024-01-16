using BCM.Infrastructure;
using System.ComponentModel;

namespace BCM.Infrastructure.Dtos.CategoriesDto
{
    public class CategoryShowDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string CreatorName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Image { get; set; }
        public Guid? ParentId { get; set; }
        public bool ShowOnHome { get; set; }
        public bool IsAllowedDeleted { get; set; }
        public IEnumerable<CategoryShowDto> SubCategories { get; set; }
    }
}
