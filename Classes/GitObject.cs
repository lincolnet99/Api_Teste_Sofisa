using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Teste_Sofisa.Classes
{
    public class GitObject
    {
        public GitObject(int id, string nome, string url, string linguagem)
        {
            Id = id;
            Nome = nome;
            Url = url;
            Linguagem = linguagem;
        }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "html_url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string Linguagem { get; set; }
    }
}