using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCIFTAN.Startup))]
namespace SCIFTAN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
