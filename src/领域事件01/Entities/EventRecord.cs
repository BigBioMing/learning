namespace 领域事件01.Entities
{
    public class EventRecord
    {
        public int Id { get; set; }
        public string Batch { get; set; } = null!;
        public string UniqueId { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime CreateTime { get; set; }
    }
}
