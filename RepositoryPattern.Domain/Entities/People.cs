namespace RepositoryPattern.Entities
{
    public sealed class People
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
        public bool IsDeleted { get; set; }
    }
}
