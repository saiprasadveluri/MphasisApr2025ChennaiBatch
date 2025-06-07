using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
public class Location{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    
    public long LocationId{get;set;}
    [StringLength(20)]
    
    public string LocationName{get;set;}

    public string? LocationDescription{get;set;}

    public List<Service> SourceList{get;set;}
    public List<Service> DestinationList{get;set;}
    
}