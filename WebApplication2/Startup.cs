using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaglikGozcusuWebService.Startup))]
namespace SaglikGozcusuWebService
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
