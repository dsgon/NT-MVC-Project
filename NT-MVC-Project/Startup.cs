using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NT_MVC_Project.Startup))]
namespace NT_MVC_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
