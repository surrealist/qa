using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(qa.Web.Startup))]
namespace qa.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
