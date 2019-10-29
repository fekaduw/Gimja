﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    
    public partial class eDMSEntity : DbContext
    {
        public eDMSEntity()
            : base("name=eDMSEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CreditStatus> CreditStatus { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<MenuType> MenuTypes { get; set; }
        public DbSet<SalesLocation> SalesLocations { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<TaxType> TaxTypes { get; set; }
        public DbSet<TelephoneFaxType> TelephoneFaxTypes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<CompanyInfo> CompanyInfoes { get; set; }
        public DbSet<CreditPayment> CreditPayments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Issuance> Issuances { get; set; }
        public DbSet<IssuedItem> IssuedItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemRequest> ItemRequests { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceivedItem> ReceivedItems { get; set; }
        public DbSet<ReturnedItem> ReturnedItems { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }
        public DbSet<SalesReturn> SalesReturns { get; set; }
        public DbSet<Stocktaking> Stocktakings { get; set; }
        public DbSet<SyncTransaction> SyncTransactions { get; set; }
        public DbSet<TelephoneFax> TelephoneFaxes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLocation> UserLocations { get; set; }
        public DbSet<SyncLog> SyncLogs { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<CustomerLedger> CustomerLedgers { get; set; }
        public DbSet<LossAdjustment> LossAdjustments { get; set; }
        public DbSet<WriteOff> WriteOffs { get; set; }
    
        public virtual ObjectResult<string> GenerateItemID(Nullable<int> rlkBrandID, Nullable<int> rlkCategoryID)
        {
            var rlkBrandIDParameter = rlkBrandID.HasValue ?
                new ObjectParameter("rlkBrandID", rlkBrandID) :
                new ObjectParameter("rlkBrandID", typeof(int));
    
            var rlkCategoryIDParameter = rlkCategoryID.HasValue ?
                new ObjectParameter("rlkCategoryID", rlkCategoryID) :
                new ObjectParameter("rlkCategoryID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GenerateItemID", rlkBrandIDParameter, rlkCategoryIDParameter);
        }
    
        public virtual ObjectResult<GetFilteredCategories_Result> GetFilteredCategories(Nullable<int> rlkBrandID)
        {
            var rlkBrandIDParameter = rlkBrandID.HasValue ?
                new ObjectParameter("rlkBrandID", rlkBrandID) :
                new ObjectParameter("rlkBrandID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetFilteredCategories_Result>("GetFilteredCategories", rlkBrandIDParameter);
        }
    
        public virtual ObjectResult<GenerateID_Result> GenerateID(string tbl, string namePrefix)
        {
            var tblParameter = tbl != null ?
                new ObjectParameter("tbl", tbl) :
                new ObjectParameter("tbl", typeof(string));
    
            var namePrefixParameter = namePrefix != null ?
                new ObjectParameter("namePrefix", namePrefix) :
                new ObjectParameter("namePrefix", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GenerateID_Result>("GenerateID", tblParameter, namePrefixParameter);
        }
    }
}
