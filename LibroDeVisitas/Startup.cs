using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibroDeVisitas.Startup))]
namespace LibroDeVisitas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
