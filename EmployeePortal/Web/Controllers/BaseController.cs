using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Loggerr;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        private ILog _Ilog;

        public BaseController() 
        {
            _Ilog = Log.GetInstance;


        }
        protected override void OnException(ExceptionContext filterContext)
        {
            _Ilog.Logexception(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }

    }
}