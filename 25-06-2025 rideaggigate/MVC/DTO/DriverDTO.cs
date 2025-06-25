using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAggrigationAPI.DTO
{
    public class DriverDTO
    {
        public Guid DiverId { get; set; }
        
        public string DriverName { get; set; }
        
        public long DriverRating { get; set; }

        public Guid UserId { get; set; }


    }
    public class DriverAddDTO
    {
        public Guid DiverId { get; set; }

        public string DriverName { get; set; }

        public long DriverRating { get; set; }

        public Guid UserId { get; set; }


    }



}
