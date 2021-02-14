using Api_Teste_Sofisa.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Api_Teste_Sofisa.Métodos
{
    public class Metodos
    {
        private const string url = "https://api.github.com/users/";
        private const string user = "lincolnet99/repos";

        public IEnumerable<GitObject> RetornoRepositorios()
        {
            HttpClient client = new HttpClient();

            IEnumerable<GitObject> responseBody = new List<GitObject>();

            client.BaseAddress = new Uri(url);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");

            using (HttpResponseMessage response = client.GetAsync(user).Result)
            {
                response.EnsureSuccessStatusCode();
                responseBody = response.Content.ReadAsAsync<IEnumerable<GitObject>>().Result;
            }

            return responseBody;
        }

        public GitObject ObterRepositorio(int id)
        {
            return RetornoRepositorios().Where(_ => _.Id == id).FirstOrDefault();
        }
    }
}