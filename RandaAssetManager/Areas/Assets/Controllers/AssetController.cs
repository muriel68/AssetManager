using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Models;
using Service.Interfaces;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;

namespace RandaAssetManager.Areas.Assets.Controllers
{
    public class AssetController : Controller
    {
        private IAssetService _assetService;
        private IUnitOfWork _uow;
        public AssetController()
        {
        }
        public AssetController(IAssetService assetService, 
                                IUnitOfWork uow)
        {
            this._assetService = assetService;
            this._uow = uow;
        }
        // GET: Assets/Asset
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Update(Asset asset)
        {
            if (ModelState.IsValid)
            {
                this._assetService.EditAsset(asset);
            }
            return View();
        }

        public ActionResult AssetDataSource(DataManager dm)
        {
            var AssetList = _assetService.GetAllAssets()
                .Select(u => new 
                {
                    AssetId = u.AssetId,
                    CategoryName = u.Category.CategoryName,
                    Name = u.Name,
                    Department = u.Department.Name,
                    Cost = u.Cost,
                    PurchaseDate = u.PurchaseDate,
                    SerielNumber = u.Description,
                    Description = u.Description
                }).ToList();

            DataResult result = new DataResult();
            DataOperations operation = new DataOperations();
            result.result = AssetList;
            result.count = AssetList.Count();

            result.result = operation.Execute(result.result, dm);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
    public class DataResult
    {
        public IEnumerable result { get; set; }
        public int count { get; set; }
    }
}