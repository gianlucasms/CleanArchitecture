using CleanArchitecure.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecure.Persistence.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
}
