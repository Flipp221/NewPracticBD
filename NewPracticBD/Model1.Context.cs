﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPracticBD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class shaurmaEntities : DbContext
    {
        public shaurmaEntities()
            : base("name=shaurmaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<lavash> lavash { get; set; }
        public virtual DbSet<Luck> Luck { get; set; }
        public virtual DbSet<myasko> myasko { get; set; }
        public virtual DbSet<number_user> number_user { get; set; }
        public virtual DbSet<ogurci> ogurci { get; set; }
        public virtual DbSet<pomidori> pomidori { get; set; }
        public virtual DbSet<price> price { get; set; }
        public virtual DbSet<roll> roll { get; set; }
        public virtual DbSet<Sklad> Sklad { get; set; }
        public virtual DbSet<sosiska> sosiska { get; set; }
        public virtual DbSet<sprice> sprice { get; set; }
        public virtual DbSet<time> time { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<uslugi> uslugi { get; set; }
    }
}
