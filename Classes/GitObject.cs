using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api_Teste_Sofisa.Classes
{
    public class GitObject
    {
        public GitObject(int id, string nome, string url, string linguagem, string descricao, DateTime ultimaatualizacao,
                         List<string> contribuintes)
        {
            Id = id;
            Nome = nome;
            Url = url;
            Linguagem = linguagem;
            Descricao = descricao;
            UltimaAtualizacao = ultimaatualizacao;
            Contribuintes = contribuintes;
        }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "html_url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string Linguagem { get; set; }

        [JsonProperty(PropertyName = "description")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        [Display(Name = "Última Atualização")]
         public DateTime UltimaAtualizacao { get; set; }

        [JsonProperty(PropertyName = "contribuitors_url")]
        [Display(Name = "Pessoas que contribuiram")]
        public List<string> Contribuintes { get; set; }
    }
}