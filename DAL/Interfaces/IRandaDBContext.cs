using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Models;

namespace DAL.Interfaces
{
    public interface IRandaDBContext
    {
        DbChangeTracker ChangeTracker { get; }
        int SaveChanges();
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet Set(Type entityType);

        [Unity.Attributes.Dependency]
        DbSet<Asset> Assets { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<EventType> EventTypes { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<Event> Events { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<Address> Addresses { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<Site> Sites { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<Category> Categories { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<Contact> Contacts { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<ContactType> ContactTypes { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<Location> Locations { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<Department> Departments { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<AuditType> AuditTypes { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<Audit> Audits { get; set; }

        [Unity.Attributes.Dependency]
        DbSet<Staff> Staffs { get; set; }
    }
}
