using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        Mock<IRepository<Asset>> _mockAssetDBSet;
        Mock<RandaDBContext> mockContext;

        public AssetServiceTest() { }


        [TestMethod]
        public void FindAsset()
        {
            var assetId = 1;
            var expected = "Asset Test";
            var asset = new Asset() { Name = expected, AssetId = assetId };

            var contextMock = new Mock<IRepository<Asset>>();
            contextMock.Setup(a => a.Add(asset)).Returns(Mock.Of<Asset>());
            //   contextMock.Setup(a => a.Set<Role>()).Returns(Mock.Of<IDbSet<Role>>);
            //   contextMock.Setup(a => a.Set<Team>()).Returns(Mock.Of<IDbSet<Team>>);
            contextMock.Verify();

            //Arrange


            //   var assetRepositoryMock = new Mock<IRepository<Asset>>();


            //   assetRepositoryMock.Setup(m => m.Add(asset)).Returns(asset).Verifiable();
            // //  assetRepositoryMock.Setup(m => m.FindBy(a => a.AssetId == assetId)).Returns(asset).Verifiable();

            //   //var uintOfWorkMock = new Mock<IUnitOfWork>();

            //   //IAssetService sut = new Service.Services.AssetService(assetRepositoryMock.Object, uintOfWorkMock.Object);
            //   ////Act;
            //   //uintOfWorkMock.Object.Save();
            //   //var actual = sut.GetAsset(assetId);


            //   //Assert
            //   assetRepositoryMock.Verify();//verify that GetByID was called based on setup.
            ////   Assert.IsNotNull(actual);//assert that a result was returned
            // //  Assert.AreEqual(expected, actual);//assert that actual result was as expected


            //   //Asset asset = new Asset()
            //   //{
            //   //    AssetId = 1,
            //   //    Name = "Cheese",
            //   //    Cost = 2
            //   //};

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
            mockService.Setup(s => s.Add(asset)).Returns(() => asset);
            var result = mockService.Object.Add(asset);
            var mockAsset = mockService.Object.FindBy(a => a.AssetId == asset.AssetId);

            Assert.AreEqual(asset, result);

        }
    }
}
