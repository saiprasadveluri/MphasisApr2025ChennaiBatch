namespace OnlineQuizWepAPI.DTO
{
    public class TopicsDTO
    {
        public Guid TopicId { get; set; }
        public string TopicName { get; set; }
        public Guid CategoryId { get; set; }
    }
    public class GetTopicsDTO
    {
        public Guid TopicId { get; set; }
        public string TopicName { get; set; }
        public Guid CategoryId { get; set; }
    }
}
