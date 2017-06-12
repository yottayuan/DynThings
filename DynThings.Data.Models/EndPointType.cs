
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DynThings.Data.Models
{

using System;
    using System.Collections.Generic;
    
public partial class EndPointType
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public EndPointType()
    {

        this.AlertConditions = new HashSet<AlertCondition>();

        this.Endpoints = new HashSet<Endpoint>();

        this.ThingEnds = new HashSet<ThingEnd>();

        this.EndPointIOs = new HashSet<EndPointIO>();

    }


    public long ID { get; set; }

    public string Title { get; set; }

    public string measurement { get; set; }

    public Nullable<long> TypeCategoryID { get; set; }

    public Nullable<long> IconID { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AlertCondition> AlertConditions { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Endpoint> Endpoints { get; set; }

    public virtual EndPointTypeCategory EndPointTypeCategory { get; set; }

    public virtual EndPointTypeCategory EndPointTypeCategory1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ThingEnd> ThingEnds { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<EndPointIO> EndPointIOs { get; set; }

}

}
