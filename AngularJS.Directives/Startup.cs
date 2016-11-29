using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJS.Directives.Startup))]
namespace AngularJS.Directives
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
