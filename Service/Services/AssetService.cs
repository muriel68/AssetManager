using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;
using Service.Interfaces;

namespace Service.Services
{
    public class AssetService : IAssetService
    {
        IRepository<Asset> _assetRepository;
        IUnitOfWork _unitOfWork;

        public IRandaDBContext Context { get; set; }

        public AssetService(IRepository<Asset> assetRepository, IUnitOfWork unitOfWork)
        {
            _assetRepository = assetRepository;
            _unitOfWork = unitOfWork; //injected
        }

        public Asset AddAsset(Asset asset)
        {
            _assetRepository.Add(asset);
            _unitOfWork.Save();
            return asset;
        }

        public void DeleteAsset(int id)
        {
            Asset assetToDelete = _assetRepository.FindBy(a => a.AssetId == id).FirstOrDefault();
           _assetRepository.Delete(assetToDelete);
        }

        public void EditAsset(Asset asset)
        {
            _assetRepository.Update(asset);
            _unitOfWork.Save();
        }

        public List<Asset> GetAllAssets()
        {
            return _assetRepository.GetAll().ToList();
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public Asset GetAsset(int id)
        {
            return _assetRepository.FindBy(a => a.AssetId == id).FirstOrDefault();
        }
    }
}
