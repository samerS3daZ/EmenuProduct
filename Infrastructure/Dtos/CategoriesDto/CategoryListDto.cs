namespace BCM.Infrastructure.Dtos.CategoriesDto
{
    public class CategoryListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<CategoryListDto> SubCategories { get; set; }
    }
}
