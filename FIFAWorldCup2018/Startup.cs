using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIFAWorldCup2018.Startup))]
namespace FIFAWorldCup2018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
