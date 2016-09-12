using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RandellCo.Startup))]
namespace RandellCo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
