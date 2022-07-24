using EksiSozlukClone.Api.Applicaton.Interfaces.Repositories;
using EksiSozlukClone.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozlukClone.Infrastructure.Persistence.Repositories
{
    public class EntryRepository : GenericRepository<EksiSozlukClone.Api.Domain.Models.Entry>, IEntryRepository
    {
        public EntryRepository(EksiSozlukCloneContext dbContext) : base(dbContext)
        {
        }
    }
}
