
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
    
public partial class VCAS_debitTrans
{

    public int Id { get; set; }

    public int FK_debitAccountsId { get; set; }

    public string name { get; set; }

    public double amount { get; set; }

    public string remittance { get; set; }

    public string payee { get; set; }

    public System.DateTime datetime { get; set; }

    public string attach_statement { get; set; }



    public virtual VCAS_debitAccounts VCAS_debitAccounts { get; set; }

}

}
