namespace EksiSozlukClone.Api.Domain.Models;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime DateTime { get; set; }
}
    
