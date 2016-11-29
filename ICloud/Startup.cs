using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICloud.Startup))]
namespace ICloud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
