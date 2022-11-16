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
    public class DetailsModel : PageModel
    {
        private readonly RepositoryPattern.Data.RepositoryPatternContext _context;

        public DetailsModel(RepositoryPattern.Data.RepositoryPatternContext context)
        {
            _context = context;
        }

      public People People { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.People == null)
            {
                return NotFound();
            }

            var people = await _context.People.FirstOrDefaultAsync(m => m.Id == id);
            if (people == null)
            {
                return NotFound();
            }
            else 
            {
                People = people;
            }
            return Page();
        }
    }
}
