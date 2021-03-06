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
    using System.ComponentModel.DataAnnotations;

    public partial class Bookingdata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bookingdata()
        {
            this.AdditionalFacilitiesandFunctions = new HashSet<AdditionalFacilitiesandFunction>();
            this.FunctionRequestedTables = new HashSet<FunctionRequestedTable>();
        }
    
        public int functionID { get; set; }
        
      
        public System.DateTime bookingDate { get; set; }
        [DataType(DataType.Date)]
    
        public System.DateTime functionDate { get; set; }
        public int noofGuest { get; set; }
        public int rateperGuest { get; set; }
        public Nullable<int> AdvancePayment { get; set; }
        public Nullable<int> RemainingPayment { get; set; }
        public int Extras { get; set; }
        public int TotalCharges { get; set; }
        public string timeShift { get; set; }
        public int MenuId { get; set; }
        public int ProgramId { get; set; }
        public long CnicNo { get; set; }
        public int customerID { get; set; }
        public string RequestStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdditionalFacilitiesandFunction> AdditionalFacilitiesandFunctions { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Program Program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FunctionRequestedTable> FunctionRequestedTables { get; set; }
    }
}
