﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginForma
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kat> Kats { get; set; }
        public virtual DbSet<MogucPosao> MogucPosaos { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<Stan> Stans { get; set; }
        public virtual DbSet<Stanar> Stanars { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UgovorenPosao> UgovorenPosaos { get; set; }
        public virtual DbSet<Ulaz> Ulazs { get; set; }
        public virtual DbSet<Uplatnica> Uplatnicas { get; set; }
        public virtual DbSet<Vlasnik> Vlasniks { get; set; }
        public virtual DbSet<Zaposlenik> Zaposleniks { get; set; }
        public virtual DbSet<Zgrada> Zgradas { get; set; }
    }
}
