using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrugstoreSchool2020.Startup))]
namespace DrugstoreSchool2020
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
