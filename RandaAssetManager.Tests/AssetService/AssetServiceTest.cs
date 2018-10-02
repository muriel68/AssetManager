using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter.Xml;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.Interfaces;

namespace RandaAssetManager.Tests.AssetService
{
    [TestClass]
    public class AssetServiceTest
    {
        public AssetServiceTest() { }

        [TestMethod]
        public void GetAll()
        {

            Asset asset = new Asset()
            {
                AssetId = 1,
                Name = "Cheese",
                Cost = 2
            };

            List<Asset> assets = new List<Asset>();
            assets.Add(asset);

            Mock<IAssetService> mockService = new Mock<IAssetService>();
            mockService.Setup(s => s.GetAllAssets()).Returns(() => assets);

            List<Asset> resultAssets = mockService.Object.GetAllAssets();

            Assert.AreEqual(assets, resultAssets);

        }

        [TestMethod]
        public void AddAsset()
        {

            Asset asset = new Asset()
            {
                AssetId = 1,
                Name = "Cheese",
                Cost = 2
            };

            Mock<IRepository<Asset>> mockService = new Mock<IRepository<Asset>>();
            mockService.Setup(s => s.Add(asset));

            var result = mockService.Object.Add(asset);

            Assert.AreEqual(asset, result);

        }
    }
}
