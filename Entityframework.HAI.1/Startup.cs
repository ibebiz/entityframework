using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entityframework.HAI._1.Startup))]
namespace Entityframework.HAI._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
