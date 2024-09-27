using APIDesafioBlip.Repositories.Interfaces;
using static System.Reflection.Metadata.BlobBuilder;
using System.Text.Json;
using APIDesafioBlip.Models;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json.Serialization;

namespace Desafio_Blip.Repositories
{
    public class RepositoryRepository: IRepositoryRepository
    {
        public HttpClient HttpClient = new HttpClient();
        private const string gitURL = "https://api.github.com/orgs/takenet/repos?language=c#&per_page=10";
        private readonly string token = "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";

        public async Task<List<Repository>> FindRepository() {

            var request = new HttpRequestMessage(HttpMethod.Get, gitURL);          
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            request.Headers.UserAgent.ParseAdd("ederjr");

            var response = await HttpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStreamAsync();
            var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(content);

            return repositories == null ? throw new Exception($"Sem repositórios encontrados") : repositories;
        }
    }
}
