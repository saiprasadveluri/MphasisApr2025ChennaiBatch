namespace QuizAPI.DTO
{
    public class CategoryDTO
    {
        public string CategoryName { get; set; }
    }
    public class GetCategoryDTO
    {
        public Guid CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
