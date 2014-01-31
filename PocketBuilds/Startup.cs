using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PocketBuilds.Startup))]
namespace PocketBuilds
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
