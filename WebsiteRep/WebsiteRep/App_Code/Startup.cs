using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteRep.Startup))]
namespace WebsiteRep
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
