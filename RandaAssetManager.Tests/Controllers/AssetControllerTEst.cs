using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandaAssetManager.Areas.Assets.Controllers;
using RandaAssetManager.Controllers;

namespace RandaAssetManager.Tests.Controllers
{
    [TestClass]
    public class AssetControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            AssetController controller = new AssetController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
