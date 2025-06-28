using System.ComponentModel.DataAnnotations;

namespace OnlineQuizApplicationAPI.DTO
{
    public class CategoryDTO
    {
        public Guid CategoryId { get; set; }
       
        public string CategoryName { get; set; }
    }
}
