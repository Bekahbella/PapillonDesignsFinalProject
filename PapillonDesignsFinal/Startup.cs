using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PapillonDesignsFinal.Startup))]
namespace PapillonDesignsFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
