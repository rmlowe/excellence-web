using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(excellence.Startup))]
namespace excellence
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
