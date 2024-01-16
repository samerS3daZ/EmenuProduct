using BCM.Domain;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BCM.Infrastructure.Dtos;
public class RequestDTO<T> where T : BaseEntity
{
    [Range(0, int.MaxValue, ErrorMessage = "Current page must be a non-negative value.")]
    [DefaultValue(1)]
    public int CurrentPage { get; set; } = 1;

    [Range(0, int.MaxValue, ErrorMessage = "Rows per page must be a non-negative value.")]
    [DefaultValue(10)]
    public int RowsPerPage { get; set; } = 10;
    [DefaultValue("Id")]
    public string? OrderByData { get; set; } = "Id";

    [DefaultValue(true)]
    [RegularExpression(@"^(True|False|true|false)$")]
    public bool ASC { get; set; } = false;

    public string? SearchingValue { get; set; }
}

public class RequestDTO
{
    public int CurrentPage { get; set; }
    public int RowsPerPage { get; set; }
    public string? OrderByData { get; set; }
    public bool ASC { get; set; }
    public string? SearchingValue { get; set; }
}