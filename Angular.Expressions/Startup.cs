using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular.Expressions.Startup))]
namespace Angular.Expressions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
