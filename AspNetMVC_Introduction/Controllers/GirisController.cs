using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_Introduction.Controllers
{
    public class GirisController : Controller
    {
        // GET: Giris
        public ActionResult AnaSayfa()
        {
            return View();
        }
    }
}