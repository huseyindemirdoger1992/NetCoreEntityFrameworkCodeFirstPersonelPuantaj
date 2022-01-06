using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Models;

namespace NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Controllers
{
    public class Vardiya : Controller
    {
        ApplicationConnectionDbString db = new ApplicationConnectionDbString();
        public IActionResult Liste()
        {
            ViewBag.Vardiya = db.Vardiya.ToList();
            return View();
        }

        public IActionResult Kaydet(Models.Vardiya V)
        {
            db.Vardiya.Add(V);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        public IActionResult Duzenle(Models.Vardiya V)
        {
            Models.Vardiya EV = db.Vardiya.FirstOrDefault(x => x.Id == V.Id);
            EV.Ad = V.Ad;
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int Id)
        {
            Models.Vardiya  Silinecek = db.Vardiya.FirstOrDefault(x => x.Id == Id);
            db.Vardiya.Remove(Silinecek);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
    }
}
