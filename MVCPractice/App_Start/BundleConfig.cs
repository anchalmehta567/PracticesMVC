using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
namespace MVCPractice
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles) 
        {
            bundles.Add(new StyleBundle("~/bundle/CSS").IncludeDirectory("~/Content/CSS", "*.css"));

       
            BundleTable.EnableOptimizations = true;
        }
    }
}