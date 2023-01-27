using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StrangeScout.Models;

namespace StrangeScout.Data
{
    public class StrangeScoutContext : DbContext
    {
        public StrangeScoutContext (DbContextOptions<StrangeScoutContext> options)
            : base(options)
        {
        }

        public DbSet<StrangeScout.Models.Matches> Matches { get; set; } = default!;
    }
}
