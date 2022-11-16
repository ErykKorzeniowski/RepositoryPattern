using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepositoryPattern.Data;
using RepositoryPattern.Entities;

namespace RepositoryPattern
{
    public class CreateModel : PageModel
    {
        private readonly RepositoryPattern.Data.RepositoryPatternContext _context;

        public CreateModel(RepositoryPattern.Data.RepositoryPatternContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public People People { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.People == null || People == null)
            {
                return Page();
            }

            _context.People.Add(People);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
