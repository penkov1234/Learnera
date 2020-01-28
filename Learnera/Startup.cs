using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Learnera.Startup))]
namespace Learnera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
