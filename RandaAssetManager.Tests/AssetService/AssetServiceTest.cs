using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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

            Mock<IAssetService> mockRepository = new Mock<IAssetService>();
            mockRepository.Setup(s => s.GetAllAssets()).Returns(() => assets);

            List<Asset> resultAssets = mockRepository.Object.GetAllAssets();

            Assert.AreEqual(assets, resultAssets);

        }
    }
}
