using EksiSozlukClone.Api.Applicaton.Interfaces.Repositories;
using EksiSozlukClone.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozlukClone.Infrastructure.Persistence.Repositories
{
    public class EmailConfirmationRepository : GenericRepository<EmailConfirmation>, IEmailConfirmationRepository
    {
        public EmailConfirmationRepository(EksiSozlukClone.Infrastructure.Persistence.Context.EksiSozlukCloneContext dbContext) : base(dbContext)
        {
        }
    }
}
