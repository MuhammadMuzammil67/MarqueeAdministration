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
    
    public partial class Beverage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Beverage()
        {
            this.beveragesWithFunctionWithMenus = new HashSet<beveragesWithFunctionWithMenu>();
            this.QuantityupdateBeveragestables = new HashSet<QuantityupdateBeveragestable>();
        }
    
        public int beverageId { get; set; }
        public string beveragesName { get; set; }
        public int beveragesSalePrice { get; set; }
        public int beveragesPurchasePrice { get; set; }
        public int quantityOfBeverages { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<beveragesWithFunctionWithMenu> beveragesWithFunctionWithMenus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuantityupdateBeveragestable> QuantityupdateBeveragestables { get; set; }
    }
}
