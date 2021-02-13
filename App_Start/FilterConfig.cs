using System.Web;
using System.Web.Mvc;

namespace Api_Teste_Sofisa
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
