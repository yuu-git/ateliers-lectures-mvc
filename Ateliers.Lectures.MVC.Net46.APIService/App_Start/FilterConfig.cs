using System.Web;
using System.Web.Mvc;

namespace Ateliers.Lectures.MVC.Net46.APIService
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
