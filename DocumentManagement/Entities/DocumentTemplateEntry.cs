namespace DocumentManagement.Entities
{
    public class DocumentTemplateEntry : BaseEntity
    {
        public string Label { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public Type DataType { get; set; }
    }
}
