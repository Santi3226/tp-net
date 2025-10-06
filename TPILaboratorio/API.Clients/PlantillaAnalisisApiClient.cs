using DTOs;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace API.Clients
{
    public class PlantillaAnalisisApiClient
    {
        private static HttpClient client = new HttpClient();
        static PlantillaAnalisisApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<PlantillaAnalisisDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("plantillasAnalisis/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<PlantillaAnalisisDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener plantilla de análisis con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener plantilla de análisis con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener plantilla de análisis con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<PlantillaAnalisisDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("plantillasAnalisis");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<PlantillaAnalisisDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de plantilla de análisis. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de plantillas de análisis: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de plantillas de análisis: {ex.Message}", ex);
            }
        }

        public async static Task AddAsync(PlantillaAnalisisDTO ta)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("plantillasAnalisis", ta);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear plantilla de análisis. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear plantilla de análisis: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear plantilla de análisis: {ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("plantillasAnalisis/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar plantilla de análisis con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar plantilla de análisis con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar plantilla de análisis con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(PlantillaAnalisisDTO ta)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("plantillasAnalisis", ta);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar plantilla de análisis con Id {ta.Id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar plantilla de análisis con Id {ta.Id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar plantilla de análisis con Id {ta.Id}: {ex.Message}", ex);
            }
        }
    }
}
