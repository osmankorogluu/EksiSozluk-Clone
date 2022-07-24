using EksiSozlukClone.Api.Applicaton.Interfaces.Repositories;
using EksiSozlukClone.Api.Domain.Models;
using EksiSozlukClone.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozlukClone.Infrastructure.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(EksiSozlukCloneContext dbContext) : base(dbContext)
        {
        }
    }
}
