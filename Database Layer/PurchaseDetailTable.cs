//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseDetailTable
    {
        public int PurchaseDetailID { get; set; }
        public Nullable<int> BookID { get; set; }
        public Nullable<int> PurchaseID { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<double> UnitPrice { get; set; }
    
        public virtual BookTable BookTable { get; set; }
        public virtual PurchaseTable PurchaseTable { get; set; }
    }
}
