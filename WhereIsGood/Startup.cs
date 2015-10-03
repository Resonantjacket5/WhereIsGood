using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhereIsGood.Startup))]
namespace WhereIsGood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
