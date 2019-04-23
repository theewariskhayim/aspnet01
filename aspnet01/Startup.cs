using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet01.Startup))]
namespace aspnet01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
