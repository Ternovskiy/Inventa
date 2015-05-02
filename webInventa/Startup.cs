using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webInventa.Startup))]
namespace webInventa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
