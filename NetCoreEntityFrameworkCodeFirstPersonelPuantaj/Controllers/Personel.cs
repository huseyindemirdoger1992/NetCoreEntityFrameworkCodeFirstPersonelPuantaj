using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Models;

namespace NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Controllers
{
    public class Personel : Controller
    {
        ApplicationConnectionDbString db = new ApplicationConnectionDbString();
        public IActionResult Liste()
        {
            ViewBag.Personel = db.Personel.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Models.Personel P)
        {
            db.Personel.Add(P);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        public IActionResult Duzenle(Models.Personel P)
        {
            Models.Personel EP = db.Personel.FirstOrDefault(x => x.Id == P.Id);
            EP.DepatmanId = P.DepatmanId;
            EP.Ad = P.Ad;
            EP.Soyad = P.Soyad;
            EP.Telefon = P.Telefon;
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int Id)
        {
            Models.Personel Silinecek = db.Personel.FirstOrDefault(x => x.Id == Id);
            db.Personel.Remove(Silinecek);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
    }
}
