﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Form114Entities : DbContext
    {
        public Form114Entities()
            : base("name=Form114Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Acheteurs> Acheteurs { get; set; }
        public virtual DbSet<Administrateurs> Administrateurs { get; set; }
        public virtual DbSet<Adresses> Adresses { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Continents> Continents { get; set; }
        public virtual DbSet<Identites> Identites { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<Prix> Prix { get; set; }
        public virtual DbSet<Produits> Produits { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<Utilisateurs> Utilisateurs { get; set; }
        public virtual DbSet<Vendeurs> Vendeurs { get; set; }
        public virtual DbSet<Villes> Villes { get; set; }
    }
}
