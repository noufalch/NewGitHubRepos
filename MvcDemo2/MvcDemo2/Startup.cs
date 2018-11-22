using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcDemo2.Startup))]
namespace MvcDemo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
