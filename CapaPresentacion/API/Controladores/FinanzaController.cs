using CapaPresentacion.API.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.API.Controladores
{
    public class FinanzaController
    {
        private HttpClient _httpClient;

        public FinanzaController() {
            _httpClient = new HttpClient();

        }

        public async Task<Finanzas> ObtenerFinanzas()
        {
            try
            {
                Finanzas finanzas = new Finanzas();
                HttpResponseMessage response = await _httpClient.GetAsync("https://fundup-finance-api.vercel.app/api/finance/getAllFinance");

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                finanzas = JsonConvert.DeserializeObject<Finanzas>(responseJson);

                return finanzas;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}
