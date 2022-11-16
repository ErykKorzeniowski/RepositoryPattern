using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Data;
using RepositoryPattern.Model;

namespace RepositoryPattern
{
    public class IndexModel : PageModel
    {
        private readonly RepositoryPattern.Data.RepositoryPatternContext _context;

        public IndexModel(RepositoryPattern.Data.RepositoryPatternContext context)
        {
            _context = context;
        }

        public IList<People> People { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.People != null)
            {
                People = await _context.People.ToListAsync();
            }
        }
    }
}
