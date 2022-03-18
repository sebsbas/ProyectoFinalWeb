using System.Web;
using System.Web.Mvc;

namespace ProyFinalWebSebastian20182578044_Julian20192578094
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
