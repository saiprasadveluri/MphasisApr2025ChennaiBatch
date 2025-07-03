using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineQuizApplicationAPI.DTO
{
    public class TopicsDTO
    {
        public string TopicName { get; set; }
    }
    public class GetTopicsDTO
    {
        public Guid TopicId { get; set; }
        public string TopicName { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
