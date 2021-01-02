using ConsultarCEPXamarin.Servico;
using ConsultarCEPXamarin.Servico.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsultarCEPXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnBuscarCep.Clicked += BuscarCep;
        }

        private void BuscarCep(object sender, EventArgs args)
        {
            //logica do problema
            //Validação
            //Buscar Na Url
          string cep = etCep.Text.Trim(); //trim remove todos os espaço que o usuario digito
          Endereco end = ViaCepServicos.BuscarEnderecoViaCep(cep);

            resultado.Text =string.Format("Edereco: {0},{1},{2}",end.localidade,end.bairro,end.logradouro) ;
        }
    }
}
