using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace Service.Interfaces
{
    public interface IAssetService : IDisposable
    {
        List<Asset> GetAllAssets();
        Asset GetAsset(int id);
        void AddAsset(Asset asset);
        void DeleteAsset(int id);
        void EditAsset(Asset asset);
    }
}
