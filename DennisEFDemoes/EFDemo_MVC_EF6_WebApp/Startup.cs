using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFDemo_MVC_EF6_WebApp.Startup))]
namespace EFDemo_MVC_EF6_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
