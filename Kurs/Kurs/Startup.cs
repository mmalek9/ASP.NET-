using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kurs.Startup))]
namespace Kurs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
