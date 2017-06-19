using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomesByMiguel.Web.Startup))]
namespace HomesByMiguel.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
