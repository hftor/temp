using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHutTestProject.Startup))]
namespace GitHutTestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
