﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sembarangKasir
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sembarangkasirEntities : DbContext
    {
        public sembarangkasirEntities()
            : base("name=sembarangkasirEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<master_barang> master_barang { get; set; }
        public virtual DbSet<master_restock> master_restock { get; set; }
        public virtual DbSet<master_user> master_user { get; set; }
        public virtual DbSet<transaksi> transaksi { get; set; }
        public virtual DbSet<uang_transaksi> uang_transaksi { get; set; }
    }
}
