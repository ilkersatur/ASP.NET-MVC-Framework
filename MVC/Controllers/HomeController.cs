using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //Varsayılan controller Home
        //Conroller içerisinde varsayılan Default Index 
        public string Index()
        {
            return "HOME";
        }
    }
}