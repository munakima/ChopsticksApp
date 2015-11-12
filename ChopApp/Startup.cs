using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChopApp.Startup))]
namespace ChopApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
