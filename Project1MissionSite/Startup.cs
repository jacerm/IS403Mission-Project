using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project1MissionSite.Startup))]
namespace Project1MissionSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
