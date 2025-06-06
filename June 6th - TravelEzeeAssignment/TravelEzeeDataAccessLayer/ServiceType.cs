using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ServiceType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int ServiceTypeId { get; set; }
    public required string ServiceTypeText { get; set; }
    public double PricePerKm { get; set; }
    public List<Service>? ServiceList { get; set; }

    public static implicit operator long(ServiceType v)
    {
        throw new NotImplementedException();
    }
}