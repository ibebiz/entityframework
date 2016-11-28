using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularIntro.Startup))]
namespace AngularIntro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
