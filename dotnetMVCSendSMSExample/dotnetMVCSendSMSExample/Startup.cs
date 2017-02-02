using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotnetMVCSendSMSExample.Startup))]
namespace dotnetMVCSendSMSExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
