
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace VCAS.Models
{

using System;
    using System.Collections.Generic;
    
public partial class VCAS_REF_items_location
{

    public int Id { get; set; }

    public int FK_councilId { get; set; }

    public int FK_REF_itemsId { get; set; }



    public virtual VCAS_council VCAS_council { get; set; }

    public virtual VCAS_REF_items VCAS_REF_items { get; set; }

}

}
