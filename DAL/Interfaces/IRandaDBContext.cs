using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Models;

namespace DAL.Interfaces
{
    public interface IRandaDBContext
    {
        [Unity.Attributes.Dependency]
       DbSet<Asset> Assets { get; set; }
    }
}
