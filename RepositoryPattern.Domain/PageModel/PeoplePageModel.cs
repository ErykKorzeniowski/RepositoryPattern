using RepositoryPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Domain.PageModel
{
    public class PeoplePageModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
        public bool IsDeleted { get; set; }

        public PeoplePageModel(PeopleEntity peopleEntity)
        {
            Id = peopleEntity.Id;   
            Name = peopleEntity.Name;
            Address = peopleEntity.Address;
            IsDeleted = peopleEntity.IsDeleted;
        }
    }
}
