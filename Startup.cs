using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortfolioApp.Startup))]
namespace PortfolioApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
