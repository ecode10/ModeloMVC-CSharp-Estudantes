using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModeloMVC.Startup))]
namespace ModeloMVC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
