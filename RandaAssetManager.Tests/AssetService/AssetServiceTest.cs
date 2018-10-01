using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            var assets = new List<Asset>() { };

         ////   var mockRepo = new Mock<IAssetService>();
         //   mockRepo.Setup(x => x.InsertCompany(company)).Returns(true);

         //   var companyObject = new Company(mockRepo.Object);
         //   var retrnData = companyObject.InsertCompany(company);

         //   var result = _assetService.GetAllAssets();
         //   Assert.Equals(new List<Asset>(), result);
        }
    }
}
