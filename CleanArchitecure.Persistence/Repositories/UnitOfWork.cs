using CleanArchitecure.Domain.Interfaces;
using CleanArchitecure.Persistence.Context;

namespace CleanArchitecure.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    public async Task CommitAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}
