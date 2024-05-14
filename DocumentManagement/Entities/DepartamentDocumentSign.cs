namespace DocumentManagement.Entities
{
    public class DepartamentDocumentSign : BaseEntity
    {
        public DocumentTemplate AssignedTemplate { get; set; }
        public Operator AssignedOperator { get; set; }
        public string Comment { get; set; }
        public RouteStatus Status { get; set; }
    }
}
