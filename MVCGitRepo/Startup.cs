using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGitRepo.Startup))]
namespace MVCGitRepo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
