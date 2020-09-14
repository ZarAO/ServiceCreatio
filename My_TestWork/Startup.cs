using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My_TestWork.Startup))]
namespace My_TestWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
