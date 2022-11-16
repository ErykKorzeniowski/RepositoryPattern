using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Model;

namespace RepositoryPattern.Data
{
    public class RepositoryPatternContext : DbContext
    {
        public RepositoryPatternContext (DbContextOptions<RepositoryPatternContext> options)
            : base(options)
        {
        }

        public DbSet<RepositoryPattern.Model.People> People { get; set; } = default!;
    }
}
