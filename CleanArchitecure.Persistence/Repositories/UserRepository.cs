using CleanArchitecure.Domain.Entities;
using CleanArchitecure.Domain.Interfaces;
using CleanArchitecure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecure.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
            
        }
        public Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}
