using DTOs;
using System.Net.Http.Headers;

namespace API.Clients
{
    public class LocalidadApiClient
    {
        private static HttpClient client = new HttpClient();
        static LocalidadApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5068/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<LocalidadDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("localidades/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<LocalidadDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener localidad con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener localidad con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener localidad con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<LocalidadDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("localidades");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<LocalidadDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de localidades. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
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
                HttpResponseMessage response = await client.PostAsJsonAsync("localidades", localidad);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear localidad. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear localidad: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear localidad: {ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("localidades/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar localidad con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar localidad con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar localidad con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(LocalidadDTO localidad)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("localidades", localidad);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar localidad con Id {localidad.Id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar localidad con Id {localidad.Id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar localidad con Id {localidad.Id}: {ex.Message}", ex);
            }
        }
    }
}
