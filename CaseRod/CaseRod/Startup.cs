using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaseRod.Startup))]
namespace CaseRod
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
