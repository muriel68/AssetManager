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
    }
}
