using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Final4125.Startup))]
namespace Final4125
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
