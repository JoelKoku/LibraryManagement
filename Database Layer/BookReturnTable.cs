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
    
    public partial class BookReturnTable
    {
        public int BookReturnID { get; set; }
        public Nullable<int> BookID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<System.DateTime> CurrentDate { get; set; }
    
        public virtual BookTable BookTable { get; set; }
        public virtual EmployeeTable EmployeeTable { get; set; }
    }
}
