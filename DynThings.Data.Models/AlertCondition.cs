
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
    
public partial class AlertCondition
{

    public long ID { get; set; }

    public long AlertID { get; set; }

    public long ThingID { get; set; }

    public long IOTypeID { get; set; }

    public long EndPointTypeID { get; set; }

    public long ConditionTypeID { get; set; }

    public string ConditionValue { get; set; }

    public bool IsMust { get; set; }



    public virtual Alert Alert { get; set; }

    public virtual AlertConditionType AlertConditionType { get; set; }

    public virtual EndPointType EndPointType { get; set; }

    public virtual IOType IOType { get; set; }

    public virtual Thing Thing { get; set; }

}

}
