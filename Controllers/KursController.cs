using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BilisimAkademi.Models;

namespace BilisimAkademi.Controllers
{
    public class KursController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Kayit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Kayit([FromForm] Aday model)
        {
            return View();
        }
    }
}
