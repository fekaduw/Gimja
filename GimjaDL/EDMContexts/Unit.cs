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
    
    public partial class Unit
    {
        public Unit()
        {
            this.Items = new HashSet<Item>();
        }
    
        public int lkUnitID { get; set; }
        public string unitName { get; set; }
        public string description { get; set; }
        public string createdBy { get; set; }
        public System.DateTime createdDate { get; set; }
        public string lastUpdatedBy { get; set; }
        public Nullable<System.DateTime> lastUpdatedDate { get; set; }
        public bool isActive { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        public virtual ICollection<Item> Items { get; set; }
    }
}
