using CleanArchitecure.Domain.Entities;
namespace CleanArchitecure.Domain.Interfaces;
public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetByEmailAsync(string email, CancellationToken cancellationToken);
}
