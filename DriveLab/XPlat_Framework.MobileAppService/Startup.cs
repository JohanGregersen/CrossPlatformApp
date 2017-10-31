using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(XPlat_Framework.MobileAppService.Startup))]

namespace XPlat_Framework.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}