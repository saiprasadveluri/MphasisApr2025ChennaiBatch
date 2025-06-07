using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

public class Service{
    [Key]


    public long ServiceId{get;set;}
   [ForeignKey(nameof(servicetype))]

    public long ServiceTypeId{get;set;}
     //[ForeignKey(nameof(Source))]

    public long SourceLocId{get;set;}
     //[ForeignKey(nameof(Destination))]

    public long DestLocId{get;set;}
    [DefaultValue(10)]
    public double Distance{get;set;}

    public Location Source{get;set;}
    public Location Destination{get;set;}
    public ServiceType servicetype{get;set;}
    public List<Booking> Curbooking{get;set;} 
}