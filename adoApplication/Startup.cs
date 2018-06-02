using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(adoApplication.Startup))]
namespace adoApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
