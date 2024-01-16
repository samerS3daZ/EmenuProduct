using BCM.Domain.Entities;

namespace BCM.Infrastructure.Dtos.CategoriesDto
{
    public class CategoryRequestDto : RequestDTO<CategoryEntity>
    {
        public override bool Equals(object? other)
        {
            if (other == null)
                return false;

            return CurrentPage == ((CategoryRequestDto)other).CurrentPage &&
                RowsPerPage == ((CategoryRequestDto)other).RowsPerPage &&
                OrderByData == ((CategoryRequestDto)other).OrderByData &&
                ASC == ((CategoryRequestDto)other).ASC &&
                SearchingValue == ((CategoryRequestDto)other).SearchingValue;
        }
    }
}
