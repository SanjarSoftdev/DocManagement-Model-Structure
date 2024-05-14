namespace DocumentManagement.Entities
{
    public class Organization : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public User Administrator { get; set; }
        public ICollection<Operator>? Operators { get; set; }
    }
}
