using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJS.ShopCart.Startup))]
namespace AngularJS.ShopCart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
