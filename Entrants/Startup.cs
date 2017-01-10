using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entrants.Startup))]
namespace Entrants
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
