namespace DocumentManagement.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public Operator Operator { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<DocumentTemplate> Templates { get; set; }
    }
}
