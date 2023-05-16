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
    
    public partial class BookTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookTable()
        {
            this.BookfineTables = new HashSet<BookfineTable>();
            this.BookReturnTables = new HashSet<BookReturnTable>();
            this.PurchaseDetailTables = new HashSet<PurchaseDetailTable>();
        }
    
        public int BookID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public string BookTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Author { get; set; }
        public string Bookname { get; set; }
        public Nullable<double> Edition { get; set; }
        public Nullable<int> TotalCopies { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        public Nullable<double> Price { get; set; }
        public string Description { get; set; }
        public Nullable<int> BookTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookfineTable> BookfineTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookReturnTable> BookReturnTables { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseDetailTable> PurchaseDetailTables { get; set; }
    }
}
