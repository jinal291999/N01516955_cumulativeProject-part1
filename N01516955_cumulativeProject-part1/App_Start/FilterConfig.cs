using System.Web;
using System.Web.Mvc;

namespace N01516955_cumulativeProject_part1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
