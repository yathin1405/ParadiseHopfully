using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParadiseHopfully.Startup))]
namespace ParadiseHopfully
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
