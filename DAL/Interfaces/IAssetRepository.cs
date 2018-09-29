using DAL.Models;
using System.Linq;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IAssetRepository : IRepository<Asset>
    {
    }
}