using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GallowayTechMVC.Startup))]
namespace GallowayTechMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
