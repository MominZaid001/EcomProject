//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcomProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Product()
        {
            this.tbl_Payment = new HashSet<tbl_Payment>();
        }
    
        public int Product_id { get; set; }
        public string Product_img { get; set; }
        public string Product_Name { get; set; }
        public string Available_Model { get; set; }
        public string Product_Description { get; set; }
        public decimal Product_Price { get; set; }
        public decimal Product_Quantity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Payment> tbl_Payment { get; set; }
    }
}