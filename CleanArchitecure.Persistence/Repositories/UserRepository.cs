using CleanArchitecure.Domain.Entities;
using CleanArchitecure.Domain.Interfaces;
using CleanArchitecure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecure.Persistence.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
        
    }
    public async Task<User> GetByEmailAsync(string email, CancellationToken cancellationToken)
    {
        return await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    }
}
