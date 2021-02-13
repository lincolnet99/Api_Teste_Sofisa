using Api_Teste_Sofisa.Classes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;

namespace Api_Teste_Sofisa.Controllers
{
    public class HomeController : Controller
    {
        private const string url = "https://api.github.com/users/";
        private const string user = "lincolnet99/repos";
        public ActionResult Index()
        {
            ViewBag.data = RetornoRepositorios();

            return View();
        }

        private IEnumerable<GitObject> RetornoRepositorios()
        {
            HttpClient client = new HttpClient();

            IEnumerable<GitObject> responseBody = new List<GitObject>();

            client.BaseAddress = new Uri(url);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");

            using (HttpResponseMessage response = client.GetAsync(user).Result) {
                response.EnsureSuccessStatusCode();
                responseBody = response.Content.ReadAsAsync<IEnumerable<GitObject>>().Result;
            }

            return responseBody;

        }
    }
}
