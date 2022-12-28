using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class GonderController : Controller
    {
        // GET: Gonder
        public ActionResult Index()
        {
            //Verilerin Controller dan View e aktarımı
            //1-ViewData
            //2-ViewBag     *
            //3-TempData
            //4-Model       ***
            //5-ViewModel   **

            ViewData["veri"] = "Bu veriyi View'e aktar...";
            ViewData["urun"] = new Urun { UrunID = 123, UrunAdi = "urun 1", Fiyat = 23 };

            ViewBag.Mesaj = "Gizli mesajj";
            ViewBag.Product = new Urun { UrunAdi = "urun 2", UrunID = 99, Fiyat = 12 };

            //Kolleksiyon Kullanımı
            List<Urun> urunler = new List<Urun>()
            {
                new Urun() {UrunAdi="Defter",UrunID=1,Fiyat=23},
                new Urun() { UrunAdi = "Kalem", UrunID = 1, Fiyat = 65 },
                new Urun() { UrunAdi = "Silgi", UrunID = 1, Fiyat = 10 }
            };

            ViewData["urunler"] = urunler;
            ViewBag.Products = urunler;
            return View();
        }
    }
}