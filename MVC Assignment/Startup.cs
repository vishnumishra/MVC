using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Assignment.Startup))]
namespace MVC_Assignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
