using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Data;
using RepositoryPattern.Data.Repositories.People;
using RepositoryPattern.Domain.PageModel;

namespace RepositoryPattern
{
    public class IndexModel : PageModel
    {
        private PeopleRepository PeopleRepository { get; set; }

        public IndexModel(PeopleRepository peopleRepository)
        {
            PeopleRepository = peopleRepository;
        }

        public IList<PeoplePageModel> People { get; set; } = default!;

        public async Task OnGetAsync()
        {
            var entities = await PeopleRepository.GetAll();

            People = entities.Select(p => new PeoplePageModel(p))
                             .ToList();
        }
    }
}
