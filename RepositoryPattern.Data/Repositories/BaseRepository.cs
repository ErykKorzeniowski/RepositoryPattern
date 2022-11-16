using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.Repositories
{
    public abstract class BaseRepository<T> where T : TEntity
    {
        protected BaseRepository(RepositoryPatternContext dbContext)
        {
            DbContext = dbContext;
        }

        protected RepositoryPatternContext DbContext { get; set; }

        public async Task<ICollection<T>> GetAll()
        {
            return await DbContext.Set<T>().ToListAsync();
        }
    }
}
