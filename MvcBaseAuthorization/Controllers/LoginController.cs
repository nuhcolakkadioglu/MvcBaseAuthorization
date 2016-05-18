using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBaseAuthorization.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection frm)
        {
            string UserName = frm["UserName"].Trim();
            string Password = frm["Password"].Trim();

            if (UserName == "nuh" && Password == "123")
            {
                Session["admin"] = "1";
                return RedirectToAction("Index", "File");
            }
            else
                return View("Index");
        }

    }
}