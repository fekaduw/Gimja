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
    
    public partial class Address
    {
        public Address()
        {
            this.Manufacturers = new HashSet<Manufacturer>();
            this.Suppliers = new HashSet<Supplier>();
            this.Warehouses = new HashSet<Warehouse>();
            this.Branches = new HashSet<Branch>();
            this.CompanyInfoes = new HashSet<CompanyInfo>();
            this.Customers = new HashSet<Customer>();
            this.Users = new HashSet<User>();
        }
    
        public System.Guid id { get; set; }
        public string kebele { get; set; }
        public string woreda { get; set; }
        public string subcity { get; set; }
        public string city_town { get; set; }
        public string street { get; set; }
        public string houseNo { get; set; }
        public string pobox { get; set; }
        public string primaryEmail { get; set; }
        public string secondaryEmail { get; set; }
        public string state_region { get; set; }
        public string country { get; set; }
        public string zipCode_postalCode { get; set; }
        public string additionalInfo { get; set; }
        public string createdBy { get; set; }
        public System.DateTime createdDate { get; set; }
        public string lastUpdatedBy { get; set; }
        public Nullable<System.DateTime> lastUpdatedDate { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        public virtual ICollection<Manufacturer> Manufacturers { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<CompanyInfo> CompanyInfoes { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
