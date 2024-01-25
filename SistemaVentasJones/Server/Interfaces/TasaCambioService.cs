using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using SistemaVentasJones.Shared; // Reemplaza 'SistemaVentasJones.Shared' con el espacio de nombres correcto si es diferente.

public class TasaCambioService : ITasaCambioService
{
    private readonly HttpClient _httpClient;

    public TasaCambioService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<decimal> ObtenerTasaCambio()
    {
        // Obtener la fecha actual en el formato necesario (yyyy-MM-dd)
        string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");

        // Construir la URL con la fecha actual
        string apiUrl = $"https://bcnexchangerate.com/api/v1/rates/{fechaActual}";

        // Realiza la llamada a la API y obtén la tasa de cambio
        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            // Lee el contenido de la respuesta y deserializa el JSON
            string content = await response.Content.ReadAsStringAsync();
            var tasaCambio = JsonConvert.DeserializeObject<TasaCambioModel>(content);

            // Devuelve el valor de la tasa de cambio
            return tasaCambio.Rate;
        }

        // Manejo de errores, puedes lanzar una excepción o devolver un valor predeterminado
        return 0;
    }
}
