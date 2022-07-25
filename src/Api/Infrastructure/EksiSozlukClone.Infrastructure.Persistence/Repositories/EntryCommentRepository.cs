using EksiSozlukClone.Api.Applicaton.Interfaces.Repositories;
using EksiSozlukClone.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozlukClone.Infrastructure.Persistence.Repositories
{
    public class EntryCommentRepository : GenericRepository<EksiSozlukClone.Api.Domain.Models.EntryComment>, IEntryCommentRepository
    {
        public EntryCommentRepository(EksiSozlukCloneContext dbContext) : base(dbContext)
        {
        }
    }
}
