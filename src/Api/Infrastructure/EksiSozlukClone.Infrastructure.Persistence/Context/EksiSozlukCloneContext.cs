﻿using EksiSozlukClone.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozlukClone.Infrastructure.Persistence.Context
{
    public class EksiSozlukCloneContext:DbContext
    {
        public const string DEFAULT_SCHEMA = "dbo";
        public EksiSozlukCloneContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User>Users { get; set; }  
        public DbSet<Entry> Entries { get; set; }  
        public DbSet<EntryVote> EntryVotes { get; set; }  
        public DbSet<EntryFavorite>EntryFavorites { get; set; }  
        public DbSet<EntryComment>EntryComments { get; set; }  
        public DbSet<EntryCommentVote>EntryCommentVotes { get; set; }  
        public DbSet<EntryCommentFavorite>EntryCommentFavorites { get; set; }  
        public DbSet<EmailConfirmation>EmailConfirmations { get; set; }  

    }
}