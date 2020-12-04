using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DoudouMons.Core.models;
using DoudouMons.Infrastructure.DAL;

namespace DoudouMons.Controllers
{
    public class ShoppingController : Controller
    {
        private DoudouContext db = new DoudouContext();

        // GET: Shopping
        public ActionResult Index()
        {
            var shoppings = db.Shoppings.Include(s => s.Customer).Include(s => s.Product);
            return View(shoppings.ToList());
        }

        // GET: Shopping/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopping shopping = db.Shoppings.Find(id);
            if (shopping == null)
            {
                return HttpNotFound();
            }
            return View(shopping);
        }

        // GET: Shopping/Create
        public ActionResult Create()
        {
            ViewBag.idCustomer = new SelectList(db.Customers, "idCustomer", "lastName");
            ViewBag.idProduct = new SelectList(db.Products, "idProduct", "name");
            return View();
        }

        // POST: Shopping/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idShopping,idCustomer,idProduct")] Shopping shopping)
        {
            if (ModelState.IsValid)
            {
                db.Shoppings.Add(shopping);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idCustomer = new SelectList(db.Customers, "idCustomer", "lastName", shopping.idCustomer);
            ViewBag.idProduct = new SelectList(db.Products, "idProduct", "name", shopping.idProduct);
            return View(shopping);
        }

        // GET: Shopping/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopping shopping = db.Shoppings.Find(id);
            if (shopping == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCustomer = new SelectList(db.Customers, "idCustomer", "lastName", shopping.idCustomer);
            ViewBag.idProduct = new SelectList(db.Products, "idProduct", "name", shopping.idProduct);
            return View(shopping);
        }

        // POST: Shopping/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idShopping,idCustomer,idProduct")] Shopping shopping)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopping).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idCustomer = new SelectList(db.Customers, "idCustomer", "lastName", shopping.idCustomer);
            ViewBag.idProduct = new SelectList(db.Products, "idProduct", "name", shopping.idProduct);
            return View(shopping);
        }

        // GET: Shopping/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopping shopping = db.Shoppings.Find(id);
            if (shopping == null)
            {
                return HttpNotFound();
            }
            return View(shopping);
        }

        // POST: Shopping/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shopping shopping = db.Shoppings.Find(id);
            db.Shoppings.Remove(shopping);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
