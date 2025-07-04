using OnlineQuizApplicationAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineQuizApplicationAPI.DTO
{
    public class AdminInfoDTO
    {
        public Guid AdminId { get; set; }
        public string AdminName { get; set; }
        public Guid AccountId { get; set; }
        public string ContactNo { get; set; }

        
    }
}
