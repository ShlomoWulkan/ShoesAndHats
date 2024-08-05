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
            Data.Get.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
