using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StrangeScout.Models;

namespace TripleStrange.Data
{
    public class MatchesModelContext : DbContext
    {
        public MatchesModelContext (DbContextOptions<MatchesModelContext> options)
            : base(options)
        {
        }

        public DbSet<StrangeScout.Models.Matches> Matches { get; set; } = default!;
    }
}
