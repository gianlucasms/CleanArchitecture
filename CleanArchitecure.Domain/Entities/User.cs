using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecure.Domain.Entities
{
   public sealed class User : BaseEntity
    {
        public string Email { get; }
        public string Name { get; } 

         
    }
}
