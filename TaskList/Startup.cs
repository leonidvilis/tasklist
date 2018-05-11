using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskList.Startup))]
namespace TaskList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
