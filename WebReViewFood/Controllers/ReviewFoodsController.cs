using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebReViewFood.Models;
using System.IO;
using WebReviewFood.Models;

namespace WebReViewFood.Controllers
{
    public class ReviewFoodsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ReviewFoods
        public ActionResult Index()
        {
            return View(db.ReviewFoods.ToList());
        }

        // GET: ReviewFoods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewFood reviewFood = db.ReviewFoods.Find(id);
            if (reviewFood == null)
            {
                return HttpNotFound();
            }
            return View(reviewFood);
        }

        // GET: ReviewFoods/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReviewFoods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReviewFood reviewFood)
        {
            
            string fileName = Path.GetFileNameWithoutExtension(reviewFood.ImageFiles.FileName);
            string extension = Path.GetExtension(reviewFood.ImageFiles.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            reviewFood.ImageCover = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
            reviewFood.ImageFiles.SaveAs(fileName);
            if (ModelState.IsValid)
            {
                db.ReviewFoods.Add(reviewFood);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reviewFood);
        }

        // GET: ReviewFoods/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewFood reviewFood = db.ReviewFoods.Find(id);
            if (reviewFood == null)
            {
                return HttpNotFound();
            }
            return View(reviewFood);
        }

        // POST: ReviewFoods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReviewFood reviewFood)
        {
            string fileName = Path.GetFileNameWithoutExtension(reviewFood.ImageFiles.FileName);
            string extension = Path.GetExtension(reviewFood.ImageFiles.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            reviewFood.ImageCover = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
            reviewFood.ImageFiles.SaveAs(fileName);
            if (ModelState.IsValid)
            {
                db.Entry(reviewFood).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reviewFood);
        }

        // GET: ReviewFoods/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewFood reviewFood = db.ReviewFoods.Find(id);
            if (reviewFood == null)
            {
                return HttpNotFound();
            }
            return View(reviewFood);
        }

        // POST: ReviewFoods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReviewFood reviewFood = db.ReviewFoods.Find(id);
            db.ReviewFoods.Remove(reviewFood);
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
