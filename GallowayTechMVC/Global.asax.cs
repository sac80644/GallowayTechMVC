using System;
using System.IO;
using System.Globalization;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GallowayTechMVC
{
	public class MvcApplication : System.Web.HttpApplication
    {
		public static string AssemblyVersionString;
		public static string AssemblyBuildDateTimeString;

		protected void Application_Start()
        {
			//begin build info
			//Get from AssemblyInfo.cs
			Assembly web = Assembly.Load("GallowayTechMVC");
			AssemblyName webName = web.GetName();
			//use either of these
			Application["AssemblyVersionString"] = webName.Version.ToString();
			AssemblyVersionString = webName.Version.ToString();

			////TODO: having a bit of issue with this date time being off...
			//Version version = webName.Version;
			//var AssemblyBuildDateTime = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.MinorRevision * 2);
			//DaylightTime dlt = TimeZone.CurrentTimeZone.GetDaylightChanges(AssemblyBuildDateTime.Year);
			//if (dlt.Start <= AssemblyBuildDateTime && AssemblyBuildDateTime < dlt.End)
			//{
			//	AssemblyBuildDateTime += dlt.Delta;
			//}

			//AssemblyBuildDateTimeString = AssemblyBuildDateTime.ToString();

			//above has issues so I will just go with file date
			FileInfo fi = new FileInfo(web.Location);
			AssemblyBuildDateTimeString = fi.CreationTime.ToString();
			//end build info

			AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

			//Database.SetInitializer(new DropCreateDatabaseAlways<YourDbContextHere>());
			//Database.SetInitializer(new DropCreateDatabaseIfModelChanges<YourDbContextHere>());
			//Database.SetInitializer(new CreateDatabaseIfNotExists<YourDbContextHere>());
		}
    }
}
