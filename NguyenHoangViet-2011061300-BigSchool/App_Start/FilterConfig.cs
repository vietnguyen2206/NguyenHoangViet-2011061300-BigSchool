using System.Web;
using System.Web.Mvc;

namespace NguyenHoangViet_2011061300_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
