using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

public class Stock
{
    public int Id { get; init; }
    
    [MaxLength(100)]
    public string Symbol { get; init; } = string.Empty;
    
    [MaxLength(100)]
    public string CompanyName { get; init; } = "";
    
    [MaxLength(100)]
    public string Industry { get; init; } = string.Empty;

    [Column(TypeName = "decimal(18,2)")]
    public decimal Purchase { get; init; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal LastDiv { get; init; }

    public long MarketCap { get; init; }

    private List<Comment> Comments { get; set; } = [];
}