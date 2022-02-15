using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeadDouble.Web.Startup))]
namespace DeadDouble.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
