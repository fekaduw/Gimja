//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GimjaDL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseOrderDetail
    {
        public System.Guid purchaseOrderDetailID { get; set; }
        public System.Guid purchaseOrderID { get; set; }
        public string itemID { get; set; }
        public string origin { get; set; }
        public int quantity { get; set; }
        public double unitPrice { get; set; }
        public string lkManufacturerID { get; set; }
        public string remark { get; set; }
        public string createdBy { get; set; }
        public System.DateTime createdDate { get; set; }
        public string lastUpdatedBy { get; set; }
        public Nullable<System.DateTime> lastUpdatedDate { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}