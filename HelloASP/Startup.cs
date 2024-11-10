using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloASP.Startup))]
namespace HelloASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
