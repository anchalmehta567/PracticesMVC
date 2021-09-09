using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyExample.Services;

namespace DependencyExample.Controllers
{
    public class UnityDemoController : Controller
    {
        // GET: UnityDemo
        IlocalWeatherServices _wethersericeprovider;
        public UnityDemoController(IlocalWeatherServices _wethersericeprovider) 
        {
            this._wethersericeprovider = _wethersericeprovider;

            _wethersericeprovider = new localWeatherServices();
        }
        public ActionResult Index()
        {
            string currentwetherInMyArea = _wethersericeprovider.GetLocalWetherByZipCode("88890");
            return View();
        }
    }
}