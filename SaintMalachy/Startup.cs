using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaintMalachy.Startup))]
namespace SaintMalachy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
