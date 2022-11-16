using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Data;
using RepositoryPattern.Entities;

namespace RepositoryPattern
{
    public class EditModel : PageModel
    {
        private readonly RepositoryPattern.Data.RepositoryPatternContext _context;

        public EditModel(RepositoryPattern.Data.RepositoryPatternContext context)
        {
            _context = context;
        }

        [BindProperty]
        public People People { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.People == null)
            {
                return NotFound();
            }

            var people =  await _context.People.FirstOrDefaultAsync(m => m.Id == id);
            if (people == null)
            {
                return NotFound();
            }
            People = people;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(People).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeopleExists(People.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PeopleExists(int id)
        {
          return (_context.People?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
