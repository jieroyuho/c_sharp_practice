using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChangeToDoc.Startup))]
namespace ChangeToDoc
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
