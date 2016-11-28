using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJS.Modules.Startup))]
namespace AngularJS.Modules
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
