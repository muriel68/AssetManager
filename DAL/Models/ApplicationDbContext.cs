using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using DAL.Interfaces;
using DAL.Repos;


namespace DAL.Models
{
    public class ApplicationDbContext : DbContext, IDisposable
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        [Unity.Attributes.Dependency]
        public DbSet<UserTokenCache> UserTokenCacheList { get; set; }
    }
}
