using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Handmade_fragrance.Startup))]
namespace Handmade_fragrance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
