﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebManagementExcelDatabase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Agentii2Entities25 : DbContext
    {
        public Agentii2Entities25()
            : base("name=Agentii2Entities25")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agentii_Table> Agentii_Table { get; set; }
        public virtual DbSet<Functie> Functies { get; set; }
        public virtual DbSet<Membrii> Membriis { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}