using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mod11_1.Startup))]
namespace Mod11_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
