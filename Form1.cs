using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BuscadorCEP
{
    public partial class buscadorCep : Form
    {

        private static HttpClient httpClientInstance;

        public buscadorCep()
        {
            InitializeComponent();
        }

        public string baseUrl
        {
            get {
                return "https://viacep.com.br/ws";
            }
        }

        private void buscarCep(string cep)
        {
            string action = string.Format("/{0}/json/", cep);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, baseUrl + action);
            HttpResponseMessage response = GetHttpClientInstance().SendAsync(request).Result;

            try
            {
                JObject enderecoCompleto = JObject.Parse(response.Content.ReadAsStringAsync().Result);
                txtLogradouro.Text = enderecoCompleto["logradouro"].ToString();
                txtBairro.Text = enderecoCompleto["bairro"].ToString();
                txtCidade.Text = enderecoCompleto["localidade"].ToString();
                txtEstado.Text = enderecoCompleto["uf"].ToString();
            } catch(Exception)
            {
                MessageBox.Show("Ops! Não encontramos este CEP. Ele foi digitado corretamente? ");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtDigitarCep.Text.Replace("-", "").Length != 8)
            {
                MessageBox.Show("Ops! Digite o CEP no formato 00000-000.");    
            } else
            {
                buscarCep(txtDigitarCep.Text.Replace("-", ""));
            }
        }

        private static HttpClient GetHttpClientInstance()
        {
            if(httpClientInstance == null)
            {
                httpClientInstance = new HttpClient();
                httpClientInstance.DefaultRequestHeaders.ConnectionClose = false;
            }
            return httpClientInstance;
        }
    }
}
