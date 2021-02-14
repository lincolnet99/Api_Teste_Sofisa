using Api_Teste_Sofisa.Classes;
using Api_Teste_Sofisa.Métodos;
using System.Web.Mvc;

namespace Api_Teste_Sofisa.Controllers
{
    public class RepositorioController : Controller
    {
        Metodos metodos = new Metodos();

        public ActionResult Index(int idRepositorio)
        {
            var repositorio = metodos.ObterRepositorio(idRepositorio);

            return View(repositorio);
        }

        public ActionResult Favoritos()
        {
            return View();
        }
    }
}