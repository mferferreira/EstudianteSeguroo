using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admStudentSecurityy.Startup))]
namespace admStudentSecurityy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
