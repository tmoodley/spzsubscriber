using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppersParadiseMailingServiceApp.Startup))]
namespace ShoppersParadiseMailingServiceApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
