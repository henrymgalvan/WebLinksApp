using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebLilnksApp.Startup))]
namespace WebLilnksApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
