using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demoApplcation.Startup))]
namespace demoApplcation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
