using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using DAL.Entities;
using DAL.Interfaces;


namespace DAL.Models
{
    public class RandaDBContext : DbContext, IRandaDBContext, IDisposable
    {
        public RandaDBContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<RandaDBContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        [Unity.Attributes.Dependency]
        public DbSet<Asset> Assets { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<EventType> EventTypes { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<Event> Events { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<Address> Addresses { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<Site> Sites { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<Category> Categories { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<Contact> Contacts { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<ContactType> ContactTypes { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<Location> Locations { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<Department> Departments { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<AuditType> AuditTypes { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<Audit> Audits { get; set; }

        [Unity.Attributes.Dependency]
        public DbSet<Staff> Staffs { get; set; }
    }

}
