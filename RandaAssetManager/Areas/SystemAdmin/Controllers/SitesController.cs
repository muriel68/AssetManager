using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Models;

namespace RandaAssetManager.Areas.SystemAdmin.Controllers
{
    public class SitesController : Controller
    {
        private ISite _siteRepo;
        private IUnitOfWork _uow;
        public  SitesController()
        {
        }
      public SitesController
        (ISite siteRepo,
            IUnitOfWork uow)
        {
            this._siteRepo = siteRepo;
            this._uow = uow;
        }

        // GET: SystemAdmin/Sites
        public ActionResult Index()
        {
            var sites = _uow.DbContext.Sites.Include(s => s.Address);
            return View(sites.ToList());
        }

        // GET: SystemAdmin/Sites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Site site = _uow.DbContext.Sites.Find(id);
            if (site == null)
            {
                return HttpNotFound();
            }
            return View(site);
        }

        // GET: SystemAdmin/Sites/Create
        public ActionResult Create()
        {
            ViewBag.AddressId = new SelectList(_uow.DbContext.Sites, "AddressId", "HouseNameOrNumber");
            return View();
        }

        // POST: SystemAdmin/Sites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SiteId,Name,Description,AddressId,Created,Modified,CreatedBy,UpdatedBy")] Site site)
        {
            if (ModelState.IsValid)
            {
                _uow.DbContext.Sites.Add(site);
                _uow.Save();
                return RedirectToAction("Index");
            }

            return View(site);
        }

        // GET: SystemAdmin/Sites/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Site site = _uow.DbContext.Sites.Find(id);
            if (site == null)
            {
                return HttpNotFound();
            }

            return View(site);
        }

        // POST: SystemAdmin/Sites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SiteId,Name,Description,AddressId,Created,Modified,CreatedBy,UpdatedBy")] Site site)
        {
            if (ModelState.IsValid)
            {
                _uow.DbContext.Entry(site).State = EntityState.Modified;
                _uow.Save();
                return RedirectToAction("Index");
            }

            return View(site);
        }

        // GET: SystemAdmin/Sites/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Site site = _uow.DbContext.Sites.Find(id);
            if (site == null)
            {
                return HttpNotFound();
            }
            return View(site);
        }

        // POST: SystemAdmin/Sites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Site site = _uow.DbContext.Sites.Find(id);
            _uow.DbContext.Sites.Remove(site);
            _uow.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _uow.DbContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
