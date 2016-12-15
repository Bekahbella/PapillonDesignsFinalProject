using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PapillonDesignsFinal.Controllers
{
    public class SpecialsController : Controller
    {
        [Authorize(Roles = "Member")]
        // GET: Specials
        public ActionResult Specials()
        {
            return View();
        }
    }
}