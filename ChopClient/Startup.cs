using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChopClient.Startup))]
namespace ChopClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
