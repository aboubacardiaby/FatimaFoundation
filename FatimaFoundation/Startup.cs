using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FatimaFoundation.Startup))]
namespace FatimaFoundation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
