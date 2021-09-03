
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace login_form_using_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

      
        public ActionResult Index()
        {
            return View();

        }
        
        [HttpPost]
        public ViewResult Index(studentclass s)
        {
            Class1.insert(s);
            ViewBag.Data = "Records inserted sucessfully";
            return View(s);


        }






    }
}
