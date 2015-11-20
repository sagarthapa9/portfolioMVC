using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortfolioMVC.Startup))]
namespace PortfolioMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
