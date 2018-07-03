using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(finalWebsite.Startup))]
namespace finalWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
