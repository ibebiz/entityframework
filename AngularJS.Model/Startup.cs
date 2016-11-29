using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJS.Model.Startup))]
namespace AngularJS.Model
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
