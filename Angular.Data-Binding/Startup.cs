using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular.Data_Binding.Startup))]
namespace Angular.Data_Binding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
