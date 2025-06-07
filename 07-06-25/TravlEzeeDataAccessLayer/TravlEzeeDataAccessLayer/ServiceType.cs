using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ServiceType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long STypeId { get; set; }
    public string ServiceTypeName { get; set; }
    public double PricePerKm { get; set; }
    public List<Service> ServiceList { get; set; }

}