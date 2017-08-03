using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LR.ClinicaMedica.UI.Site.Startup))]
namespace LR.ClinicaMedica.UI.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
