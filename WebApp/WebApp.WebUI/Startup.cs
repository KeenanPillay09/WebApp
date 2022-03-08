using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp.WebUI.Startup))]
namespace WebApp.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
