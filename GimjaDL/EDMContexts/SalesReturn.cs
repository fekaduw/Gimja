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
    
    public partial class SalesReturn
    {
        public SalesReturn()
        {
            this.ReturnedItems = new HashSet<ReturnedItem>();
        }
    
        public System.Guid id { get; set; }
        public System.Guid salesID { get; set; }
        public System.DateTime date { get; set; }
        public string processedBy { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public string reason { get; set; }
        public string createdBy { get; set; }
        public System.DateTime createdDate { get; set; }
        public string lastUpdatedBy { get; set; }
        public Nullable<System.DateTime> lastUpdatedDate { get; set; }
    
        public virtual ICollection<ReturnedItem> ReturnedItems { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
