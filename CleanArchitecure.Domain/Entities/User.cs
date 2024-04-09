using CleanArchitecure.Domain.Common;

namespace CleanArchitecure.Domain.Entities;

public sealed class User : BaseEntity
{
    public string? Email { get; set; }
    public string? Name { get; set; } 
}
