using System.ComponentModel.DataAnnotations;Add commentMore actions
using System.ComponentModel.DataAnnotations.Schema;
public class ServiceType{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long STypeId { get; set;}
    public string ServiceTypeName { get; set;}
    public double PricePerKm { get; set;}

    public List<Services> ServiceList {get; set;}
}