using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Web.Mvc;

namespace GallowayTechMVC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			//this is set in Global.asax.cs
			ViewBag.AssemblyVersionString = HttpContext.Application["AssemblyVersionString"];

			return View();
		}

		public ActionResult About()
		{
			//ViewBag.Message = "Your application description page.";

			//this is set in Global.asax.cs
			ViewBag.AssemblyVersionString = HttpContext.Application["AssemblyVersionString"];

			return View();
		}

		public ActionResult Contact()
		{
			//ViewBag.Message = "Your contact page.";

			//this is set in Global.asax.cs
			ViewBag.AssemblyVersionString = HttpContext.Application["AssemblyVersionString"];

			return View();
		}

		public ActionResult Resume()
		{
			//ViewBag.Message = "Your contact page.";

			//this is set in Global.asax.cs
			ViewBag.AssemblyVersionString = HttpContext.Application["AssemblyVersionString"];

			return View();
		}
	}
}