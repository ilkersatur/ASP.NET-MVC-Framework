using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        //// Controller içindeki metodlara Action denir.
        //public ActionResult Index() //İlk çalışan varsayılan aksiyondur.
        //{
        //    return View();
        //}
        public ActionResult HtmlSayfa() //Sağ tık -> Add view -> Html sayfası oluşturur
        {
            return View();
            return Content("ActionResult");
        }
        public string Index()
        {
            return "Merhaba MVC";
            //Çalıştığında ISS Express sanal bir sunucu oluşturur.
            //http://localhost:50397/Default/Index
            //http://localhost:50397/Default/

        }

        public string Naber()
        {
            return "NABER?";
            //http://localhost:50397/Default/Naber
        }

        public string Sayfa()
        {
            return "<h1>HTML SAYFASI</h1>";
            //http://localhost:50397/Default/Sayfa
        }
    }
}