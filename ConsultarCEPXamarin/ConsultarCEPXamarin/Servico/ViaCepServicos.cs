using ConsultarCEPXamarin.Servico.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsultarCEPXamarin.Servico
{
    public class ViaCepServicos
    {
        private static string EnderecoUrl = @"https://viacep.com.br/ws/{0}/json/";

        public  static Endereco BuscarEnderecoViaCep(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoUrl, cep);

            //vai fazer a busca na url
            WebClient wc = new WebClient();
           string conteudo =    wc.DownloadString(NovoEnderecoURL);

            //converter para um objeto do Tipo Endereço
            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            return end;
        }
    }
}
