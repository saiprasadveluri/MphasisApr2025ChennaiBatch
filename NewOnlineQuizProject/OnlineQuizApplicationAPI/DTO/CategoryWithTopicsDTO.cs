namespace OnlineQuizApplicationAPI.DTO
{
    public class CategoryWithTopicsDTO
    {
        public string CategoryName { get; set; }
        public List<TopicsDTO> Topics { get; set; } 
    }
    public class GetCategoryWithTopicsDTO
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<GetTopicsDTO> Topics { get; set; }
    }
} 
