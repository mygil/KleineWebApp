using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KleineWebApp.Startup))]
namespace KleineWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
