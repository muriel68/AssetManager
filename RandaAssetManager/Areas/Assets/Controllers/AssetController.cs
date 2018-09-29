using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Models;

namespace RandaAssetManager.Areas.Assets.Controllers
{
    public class AssetController : Controller
    {
        private IAssetRepository _assetRepo;
        private IUnitOfWork _uow;
        public AssetController()
        {
        }
        public AssetController(IAssetRepository assetRepo, 
                                IUnitOfWork uow)
        {
            this._assetRepo = assetRepo;
            this._uow = uow;
        }
        // GET: Assets/Asset
        public ActionResult Index()
        {
            var assets = this._assetRepo.GetAll(); 
            return View(assets);
        }

        public ActionResult Update(Asset asset)
        {
            if (ModelState.IsValid)
            {
                this._assetRepo.Update(asset);
            }
            return View();
        }
    }
}