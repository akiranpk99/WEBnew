using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebReViewFood.Startup))]
namespace WebReViewFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
