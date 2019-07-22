using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(alazaraqalabyadh.Startup))]
namespace alazaraqalabyadh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
