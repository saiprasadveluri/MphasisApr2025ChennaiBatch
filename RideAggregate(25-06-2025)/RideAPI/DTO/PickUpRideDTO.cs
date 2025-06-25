using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAPI.DTO
{
    public class PickUpRideDTO
    {
        public Guid PickId { get; set; }

        public Guid SourceLoc { get; set; }

        public Guid DestinationLoc { get; set; }

        public Guid CustId { get; set; }

        public Guid DriverId { get; set; }
    }
}
