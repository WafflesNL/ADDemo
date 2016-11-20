using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdDemo.Startup))]
namespace AdDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
