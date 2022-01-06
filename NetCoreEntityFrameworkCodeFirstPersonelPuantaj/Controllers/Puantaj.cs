using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Models;

namespace NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Controllers
{
    public class Puantaj : Controller
    {
        ApplicationConnectionDbString db = new ApplicationConnectionDbString();
        public IActionResult Liste()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Kaydet(Models.Personel P)
        {
            Models.Personel EP = db.Personel.FirstOrDefault(x => x.Id == P.Id);
            EP.Pazartesi = P.Pazartesi;
            EP.Sali = P.Sali;
            EP.Carsamba = P.Carsamba;
            EP.Persembe = P.Persembe;
            EP.Cuma = P.Cuma;
            EP.Cumartesi = P.Cumartesi;
            EP.Pazar = P.Pazar;
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
    }
}
