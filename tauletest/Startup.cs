using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tauletest.Startup))]
namespace tauletest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
