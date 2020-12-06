using Microsoft.EntityFrameworkCore;
using MyCms.Domain.Model.Page;
using MyCms.Domain.Model.PageGroup;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCms.Infra.Data.Context
{
    public class MyCmsContext : DbContext
    {
        public MyCmsContext(DbContextOptions<MyCmsContext> options) : base(options)
        {

        }

        public DbSet<PageGroup> PageGroups { get; set; }
        public DbSet<Page> Pages { get; set; }
    }
}
