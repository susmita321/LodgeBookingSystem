using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LodgeBookingSystem.Startup))]
namespace LodgeBookingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
