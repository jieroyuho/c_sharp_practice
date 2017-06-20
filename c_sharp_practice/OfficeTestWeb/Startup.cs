using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OfficeTestWeb.Startup))]
namespace OfficeTestWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
