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
    
    public partial class Branch
    {
        public Branch()
        {
            this.Issuances = new HashSet<Issuance>();
            this.ItemRequests = new HashSet<ItemRequest>();
            this.Sales = new HashSet<Sale>();
            this.TelephoneFaxes = new HashSet<TelephoneFax>();
            this.UserLocations = new HashSet<UserLocation>();
            this.tblLossAdjustments = new HashSet<LossAdjustment>();
            this.tblStocktakings = new HashSet<Stocktaking>();
        }
    
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }
        public string createdBy { get; set; }
        public System.DateTime createdDate { get; set; }
        public string lastUpdatedBy { get; set; }
        public Nullable<System.DateTime> lastUpdatedDate { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<System.Guid> addressID { get; set; }
        public bool isDefault { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual ICollection<Issuance> Issuances { get; set; }
        public virtual ICollection<ItemRequest> ItemRequests { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<TelephoneFax> TelephoneFaxes { get; set; }
        public virtual ICollection<UserLocation> UserLocations { get; set; }
        public virtual ICollection<LossAdjustment> tblLossAdjustments { get; set; }
        public virtual ICollection<Stocktaking> tblStocktakings { get; set; }
    }
}
