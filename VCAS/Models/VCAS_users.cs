
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
    
public partial class VCAS_users
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public VCAS_users()
    {

        this.VCAS_district = new HashSet<VCAS_district>();

    }


    public int Id { get; set; }

    public string fullName { get; set; }

    public string userName { get; set; }

    public string email { get; set; }

    public string password { get; set; }

    public int FK_userRolesId { get; set; }



    public virtual VCAS_REF_userRoles VCAS_REF_userRoles { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<VCAS_district> VCAS_district { get; set; }

}

}
