using EcoleWASM.Shared;
using System.Net.Http.Json;

namespace EcoleWASM.Client.Services
{
    public class EleveService
    {
        private readonly HttpClient http;

        public EleveService( HttpClient httpClient)
        {
            http = httpClient;
        }

        public async Task<List<EleveDTO>?> GetEleve()
        {
            var eleves = await http.GetFromJsonAsync<List<EleveDTO>>("api/eleve");
            return eleves;
        }

        public async void InsertEleve(EleveDTO eleve)
        {
            await http.PostAsJsonAsync("api/eleve",eleve);
        }
    }
}
