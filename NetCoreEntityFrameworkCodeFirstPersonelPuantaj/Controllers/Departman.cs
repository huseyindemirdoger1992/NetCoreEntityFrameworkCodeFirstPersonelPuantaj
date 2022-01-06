using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Models;

namespace NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Controllers
{
    public class Departman : Controller
    {
        ApplicationConnectionDbString db = new ApplicationConnectionDbString();
        public IActionResult Liste()
        {
            ViewBag.Departman = db.Departman.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Models.Departman D)
        {
            db.Departman.Add(D);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
        [HttpPost]
        public IActionResult Duzenle(Models.Departman D)
        {
            Models.Departman ED = db.Departman.FirstOrDefault(x => x.Id == D.Id);
            ED.Ad = D.Ad;
            ED.Aciklama = D.Aciklama;
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int Id)
        {
            foreach (Models.Personel item in db.Personel.Where(x => x.DepatmanId == Id).ToList())
            {
                if (item.DepatmanId == Id)
                {
                    item.DepatmanId = 1;
                    db.SaveChanges();
                }
            }
            Models.Departman Silinecek = db.Departman.FirstOrDefault(x => x.Id == Id);
            db.Departman.Remove(Silinecek);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
    }
}
