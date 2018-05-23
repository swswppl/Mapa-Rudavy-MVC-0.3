using System.Web;
using System.Web.Mvc;

namespace Mapa_Rudavy_MVC_0._3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
