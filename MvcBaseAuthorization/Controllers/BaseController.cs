using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBaseAuthorization.Controllers
{
    public class BaseController : Controller
    {

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            string ControllerName = filterContext.RouteData.Values["controller"].ToString();



            if(Session["admin"]==null || Session["admin"].ToString()!="1")
            {
                filterContext.Result = new RedirectResult("Login");
                return;
            }


            base.OnActionExecuting(filterContext);
        }

    }
}