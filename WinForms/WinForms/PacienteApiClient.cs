using DTOs;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WinForms
{
    public class PacienteApiClient
    {
        private static HttpClient client = new HttpClient();
        static PacienteApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<PacienteDTO> GetAsync(int id)
        {
            PacienteDTO paciente = null;
            HttpResponseMessage response = await client.GetAsync("pacientes/" + id);
            if (response.IsSuccessStatusCode)
            {
                paciente = await response.Content.ReadAsAsync<PacienteDTO>();
            }
            return paciente;
        }

        public static async Task<IEnumerable<PacienteDTO>> GetAllAsync()
        {
            IEnumerable<PacienteDTO> pacientes = null;
            HttpResponseMessage response = await client.GetAsync("pacientes");
            if (response.IsSuccessStatusCode)
            {
                pacientes = await response.Content.ReadAsAsync<IEnumerable<PacienteDTO>>();
            }
            return pacientes;
        }

        public async static Task AddAsync(PacienteDTO paciente)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("pacientes", paciente);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("pacientes/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(PacienteDTO paciente)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("pacientes", paciente);
            response.EnsureSuccessStatusCode();
        }
    }
}
