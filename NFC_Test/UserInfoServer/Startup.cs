using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserInfoServer.Startup))]
namespace UserInfoServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
