﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCPractice.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookDBEntities : DbContext
    {
        public BookDBEntities()
            : base("name=BookDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<readingbook> readingbooks { get; set; }
        public virtual DbSet<Address_tbl> Address_tbl { get; set; }
        public virtual DbSet<Employee_tbl> Employee_tbl { get; set; }
        public virtual DbSet<Registration_tbl> Registration_tbl { get; set; }
    }
}
