using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBaseAuthorization.Controllers
{
    public class VideoController : BaseController
    {
        // GET: Video
        public ActionResult Index()
        {
            return View();
        }
    }
}