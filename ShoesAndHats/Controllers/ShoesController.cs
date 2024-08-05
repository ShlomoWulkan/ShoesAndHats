using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoesAndHats.DAL;
using ShoesAndHats.Models;

namespace ShoesAndHats.Controllers
{
    public class ShoesController : Controller
    {
        // GET: ShoesController
        public ActionResult Index()
        {
            return View(Data.Get.Shoes.ToList());
        }

        // GET: ShoesController/Details/5
        public ActionResult Details(int id)
        {
            Shoes? Shoes = Data.Get.Shoes.Find(id);
            return View(Shoes);
        }

        // GET: ShoesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoesController/Create
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(Shoes shoes)
        {
            try
            {
                Data.Get.Shoes.Add(shoes);
                Data.Get.SaveChanges(); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoesController/Edit/5
        public ActionResult Edit(int id)
        {
            Shoes? Shoes = Data.Get.Shoes.Find(id);
            return View(Shoes);
        }

        // POST: ShoesController/Edit/5
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Shoes shoes)
        {
            try
            {
                Shoes? Shoes = Data.Get.Shoes.Find(id);
                if (Shoes == null) return RedirectToAction("index");
                Shoes.Size = shoes.Size;
                Shoes.Brands = shoes.Brands;
                Shoes.Color = shoes.Color;
                Shoes.UrlImage = shoes.UrlImage;
                Data.Get.Shoes.Update(shoes);
                Data.Get.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoesController/Delete/5
        public ActionResult Delete(int Id)
        {
            Shoes? Shoes = Data.Get.Shoes.Find(Id);
            if (Shoes == null) return RedirectToAction("index");
            Data.Get.Shoes.Remove(Shoes);
            Data.Get.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
