using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class leadContext : DbContext
    {
        public leadContext (DbContextOptions<leadContext> options)
            : base(options)
        {
        }

        public DbSet<leadItem> leadItem { get; set; }
    }
