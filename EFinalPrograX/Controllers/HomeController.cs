using Exceptionless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFinalPrograX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            // Submit logs
            ExceptionlessClient.Default.SubmitLog("Logging made easy");

            // You can also specify the log source and log level.
            // We recommend specifying one of the following log levels: Trace, Debug, Info, Warn, Error
            ExceptionlessClient.Default.SubmitLog(typeof(InvalidProgramException).FullName, "Proceso exitoso", "Info");
            ExceptionlessClient.Default.CreateLog(typeof(InvalidProgramException).FullName, "Proceso exitoso", "Info").AddTags("CiudadDelDollar").Submit();

            ExceptionlessClient.Default.SubmitLog(typeof(InvalidProgramException).FullName, "Oops error", "Error");
            ExceptionlessClient.Default.CreateLog(typeof(InvalidProgramException).FullName, "Oops error", "Error").AddTags("CiudadDelDollar").Submit();

            // Submit feature usages
            ExceptionlessClient.Default.SubmitFeatureUsage("MyFeature");
            ExceptionlessClient.Default.CreateFeatureUsage("MyFeature").AddTags("CiudadDelDollar").Submit();

            // Submit a 404
            ExceptionlessClient.Default.SubmitNotFound("/somepage");
            ExceptionlessClient.Default.CreateNotFound("/somepage").AddTags("CiudadDelDollar").Submit();
            return View();
        }
    }
}
