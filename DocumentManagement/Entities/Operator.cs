namespace DocumentManagement.Entities
{
    public class Operator : BaseEntity
    {
        public string Name { get; set; }
        public Department Departments { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<DepartamentDocumentSign> Routes { get; set; }
    }
}
