using DTOs;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace API.Clients
{
    public class CentroAtencionApiClient : BaseApiClient
    {
        public static async Task<CentroAtencionDTO> GetAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.GetAsync("centrosAtencion/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CentroAtencionDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener centro de atencion con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener centro de atencion con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener centro de atencion con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<CentroAtencionDTO>> GetAllAsync()
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                return await client.GetFromJsonAsync<IEnumerable<CentroAtencionDTO>>("centrosAtencion");
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de centros de atencion: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de centros de atencion: {ex.Message}", ex);
            }
        }

        public static async Task AddAsync(CentroAtencionDTO centroAtencion)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PostAsJsonAsync("centroAtencion", centroAtencion);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear centro de atencion. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear centro de atencion: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear centro de atencion: {ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.DeleteAsync("centrosAtencion/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar centro de atencion con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar centro de atencion con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar centro de atencion con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(CentroAtencionDTO centroAtencion)
        {
            try
            {
                using var client = await CreateHttpClientAsync();
                HttpResponseMessage response = await client.PutAsJsonAsync("centrosAtencion", centroAtencion);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar centro de atencion con Id {centroAtencion.Id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar centro de atencion con Id {centroAtencion.Id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar centro de atencion con Id {centroAtencion.Id}: {ex.Message}", ex);
            }
        }
    }
}