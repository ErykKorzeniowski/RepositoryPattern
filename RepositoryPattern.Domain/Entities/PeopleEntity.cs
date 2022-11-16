using RepositoryPattern.Domain.Entities;

namespace RepositoryPattern.Domain.Entities
{
    public sealed class PeopleEntity : TEntity
    {
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
    }
}
