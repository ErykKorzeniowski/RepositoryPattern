using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace RepositoryPattern.Data
{
    public class RepositoryPatternContext : DbContext
    {
        public RepositoryPatternContext (DbContextOptions<RepositoryPatternContext> options)
            : base(options)
        {
        }

        public DbSet<RepositoryPattern.Entities.People> People { get; set; } = default!;
    }
}
