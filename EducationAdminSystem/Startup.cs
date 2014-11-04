using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EducationAdminSystem.Startup))]
namespace EducationAdminSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
