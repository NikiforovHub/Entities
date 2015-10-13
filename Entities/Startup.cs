using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entities.Startup))]
namespace Entities
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
