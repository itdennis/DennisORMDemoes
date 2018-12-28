using System.Web;
using System.Web.Mvc;

namespace EFDemo_MVC_EF6_WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
