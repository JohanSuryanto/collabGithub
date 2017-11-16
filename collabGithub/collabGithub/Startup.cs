using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(collabGithub.Startup))]
namespace collabGithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
