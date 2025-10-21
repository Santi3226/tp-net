using DTOs;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace API.Clients
{
    public class TipoAnalisisApiClient : BaseApiClient
    {
        public static async Task<TipoAnalisisDTO> GetAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync("tiposAnalisis/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<TipoAnalisisDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener tipo de análisis con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener tipo de análisis con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener tipo de análisis con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<TipoAnalisisDTO>> GetAllAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                return await client.GetFromJsonAsync<IEnumerable<TipoAnalisisDTO>>("tiposAnalisis");
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de tipos de análisis: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de tipos de análisis: {ex.Message}", ex);
            }
        }

        public static async Task AddAsync(TipoAnalisisDTO ta)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PostAsJsonAsync("tiposAnalisis", ta);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear tipo de análisis. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear tipo de análisis: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear tipo de análisis: {ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.DeleteAsync("tiposAnalisis/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar tipo de análisis con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar tipo de análisis con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar tipo de análisis con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(TipoAnalisisDTO ta)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PutAsJsonAsync("tiposAnalisis", ta);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar tipo de análisis con Id {ta.Id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar tipo de análisis con Id {ta.Id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar tipo de análisis con Id {ta.Id}: {ex.Message}", ex);
            }
        }
    }
}
