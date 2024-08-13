using System.ComponentModel.DataAnnotations;

namespace api.Models;

public class Comment
{
    public int Id { get; init; }
    
    [MaxLength(100)]
    public string Title { get; init; } = string.Empty;
    
    [MaxLength(100)]
    public string Content { get; init; } = string.Empty;
    
    public DateTime CreatedOn { get; init; } = DateTime.Now;
    
    public int? StockId { get; init; }
    
    public Stock? Stock { get; init; }
}