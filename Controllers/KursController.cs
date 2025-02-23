using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BilisimAkademi.Models;

namespace BilisimAkademi.Controllers
{
    public class KursController : Controller
    {
        public IActionResult Index()
        {    
                var model = Depo.Uygulamalar;
                return View(model);   
        }
        public IActionResult Kayit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Kayit([FromForm] Aday model)
        {
            if(Depo.Uygulamalar.Any(c=>c.Eposta.Equals(model.Eposta)))
            {
                ModelState.AddModelError("", "Önceden bir başvurunuz var.");
            }

            if(ModelState.IsValid)
            {
            Depo.Ekle(model);
            return View("Geribildirim",model);
            }
            return View();
        }
    }
}
