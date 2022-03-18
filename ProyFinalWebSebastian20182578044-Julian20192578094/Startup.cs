using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyFinalWebSebastian20182578044_Julian20192578094.Startup))]
namespace ProyFinalWebSebastian20182578044_Julian20192578094
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
