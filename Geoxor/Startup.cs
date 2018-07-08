using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Geoxor.Startup))]
namespace Geoxor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
