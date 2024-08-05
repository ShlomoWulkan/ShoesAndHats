using Microsoft.AspNetCore.Mvc;
using ShoesAndHats.DAL;
using ShoesAndHats.Models;

namespace ShoesAndHats.Controllers
{
    public class HatsController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.Get.Hats);
        }

        public IActionResult CreateHat()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CreateHat(Hats? hat)
        {
            if (hat == null) return RedirectToAction("CreateHat");
            Data.Get.Hats.Add(hat);
            Data.Get.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteHat(int? id)
        {
            if (id == null) return RedirectToAction("index");
            Hats? hat  = Data.Get.Hats.FirstOrDefault(h => h.Id == id);
            if (hat == null) return RedirectToAction("index");
            Data.Get.Hats.Remove(hat);
            TempData["DeleteMessage"] = "הנתונים נמחקו בהצלחה";
            Data.Get.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditHat(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            Hats? hat = Data.Get.Hats.FirstOrDefault(h => h.Id == id);
            if (hat == null) return RedirectToAction("index");
            return View(hat);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditHat(Hats? hat)
        {
            if (hat.Id == null) return RedirectToAction("Index");
            Hats? currentHat = Data.Get.Hats.FirstOrDefault(f => f.Id == hat.Id);
            if (currentHat == null) return RedirectToAction("Index");
            currentHat.Size = hat.Size;
            currentHat.Color = hat.Color;
            currentHat.Brand = hat.Brand;
            currentHat.Url = hat.Url;

            Data.Get.Hats.Update(currentHat);
            TempData["UpdateMessage"] = "הנתונים עודכנו בהצלחה";
            Data.Get.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            Hats? hat = Data.Get.Hats.FirstOrDefault(h => h.Id == id);
            if (hat == null) return RedirectToAction("Index");
            return View(hat);
        }

    }
}
