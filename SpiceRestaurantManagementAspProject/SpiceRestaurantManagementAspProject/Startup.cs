using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpiceRestaurantManagementAspProject.Startup))]
namespace SpiceRestaurantManagementAspProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
