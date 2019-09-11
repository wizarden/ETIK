using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETIK.Startup))]
namespace ETIK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
