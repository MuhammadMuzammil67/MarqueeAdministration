//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuantityupdateBeveragestable
    {
        public int changebeveID { get; set; }
        public int beverageID { get; set; }
        public System.DateTime Date { get; set; }
        public int Quantity { get; set; }
    
        public virtual Beverage Beverage { get; set; }
    }
}
