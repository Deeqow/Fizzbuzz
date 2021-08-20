using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FizzBuzz.Startup))]
namespace FizzBuzz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
