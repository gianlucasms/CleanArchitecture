using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecure.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitAsync(CancellationToken cancellationToken);
    }
}
