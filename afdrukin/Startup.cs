using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(afdrukin.Startup))]
namespace afdrukin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
