using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenHoangViet_2011061300_BigSchool.Startup))]
namespace NguyenHoangViet_2011061300_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
