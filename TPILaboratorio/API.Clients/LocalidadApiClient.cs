using DTOs;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace API.Clients
{
    public class LocalidadApiClient : BaseApiClient
    {
        public static async Task<LocalidadDTO> GetAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync("localidades/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<LocalidadDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener Localidad con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener Localidad con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener Localidad con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<LocalidadDTO>> GetAllAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                return await client.GetFromJsonAsync<IEnumerable<LocalidadDTO>>("localidades");
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de localidades: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de localidades: {ex.Message}", ex);
            }
        }

        public async static Task AddAsync(LocalidadDTO localidad)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PostAsJsonAsync("localidades", localidad);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear localidades. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear localidades: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear localidades: {ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.DeleteAsync("localidades/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar localidades con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar localidades con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar localidades con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(LocalidadDTO localidades)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PutAsJsonAsync("localidades", localidades);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar localidades con Id {localidades.Id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar localidades con Id {localidades.Id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar localidades con Id {localidades.Id}: {ex.Message}", ex);
            }
        }
    }
}
