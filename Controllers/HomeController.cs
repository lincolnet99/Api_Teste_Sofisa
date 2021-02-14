using System.Web.Mvc;
using Api_Teste_Sofisa.Métodos;

namespace Api_Teste_Sofisa.Controllers
{
    public class HomeController : Controller
    {
        Metodos metodos = new Metodos();
        public ActionResult Index()
        {
            ViewBag.data = metodos.RetornoRepositorios();

            return View();
        }


    }
}
