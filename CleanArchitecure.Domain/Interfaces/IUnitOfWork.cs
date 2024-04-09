namespace CleanArchitecure.Domain.Interfaces;

public interface IUnitOfWork
{
    Task CommitAsync(CancellationToken cancellationToken);
}


