using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;

namespace Service.Interfaces
{
    public interface IAssetService : IDisposable
    {
     //   IRandaDBContext Context { get; set; }

        List<Asset> GetAllAssets();
        Asset GetAsset(int id);
        Asset AddAsset(Asset asset);
        void DeleteAsset(int id);
        void EditAsset(Asset asset);
    }
}
