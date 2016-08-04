using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BATBuilder.Startup))]
namespace BATBuilder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
