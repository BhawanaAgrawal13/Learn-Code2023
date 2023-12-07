using PexelOpenApi.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PexelOpenApi.Service
{
    public class PexelsService
    {
        private static string _token = "";
        private static string _baseAddress;
        private static int _photoCount;
        private HttpClient client;

        public PexelsService(IConfiguration configuration)
        {
           AssignDefaults(configuration);

            if (client == null)
            {
                this.CreateClient();
            }
        }

        private void AssignDefaults(IConfiguration configuration)
        {
            _baseAddress = configuration["PexelDeafults:baseAddreess"];
            _token = configuration["AccessToken:apiKey"];
            _photoCount = Convert.ToInt32(configuration["PexelDeafults:NumberOfPhotos"]);
        }

        private HttpClient CreateClient()
        {
            client = new HttpClient();
            SetupClientDefaults(client);
            return client;
        }

        protected virtual void SetupClientDefaults(HttpClient client)
        {
            client.BaseAddress = new Uri(_baseAddress);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", _token);
        }

        public async Task<PexelsApiResponse> GetPexelPhotoAsync()
        {
            try
            {
                var response = await client.GetAsync($"curated?per_page={_photoCount}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<PexelsApiResponse>();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<PexelsPhoto> GetRandomPhotos()
        {
            var pexelsResponse = GetPexelPhotoAsync();

            return pexelsResponse.Result.Photos;
        }

        public async Task<PexelsApiResponse> GetSearchedPhotos(string query)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"search?query={Uri.EscapeDataString(query)}&per_page={_photoCount}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<PexelsApiResponse>();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex) 
            {
                return null;
            }
        }

        public List<PexelsPhoto> DisplaySearchImages(string query)
        {
            var searchedImages = GetSearchedPhotos(query);

            return searchedImages.Result.Photos;
        }
    }
}
