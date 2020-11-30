using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace fmg_demo_master
{

    public interface ILinkedInService
    {
        Task<string> Get();

    }
    public class LinkedInService : ILinkedInService
    {
        private HttpClient _httpClient;
        public LinkedInService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Get()
        {
            string accessToken = "AQXretBOwQM94KOukVEvCxPnEI6t3uwWZCUjB5k_S27c4VNDWhX9EaUG1oH1nYsDEk1wf9JauRGh_v2hgGpyT_bPB4ETq3j8cmAvx9XkYXSDhDLXbFMKeZdsU08Mp1uDPOrvXvN4LncyfPXtiOAv8AxabtHuGfKr0vGrwzwLqwsYDpGu5t2-hDFXarMEXW0TV6zjUgSU6BTA-vsfrYUmxvHOSoGxP3eh7kP2Z6JtCdDo_izRGArRHgnytOTJ9lj0nbx-P3KCtiF8o5bRqLwMPsrM5sNwGYksIYRWz0aORgvf4IaWposZXl-8VLjDTf4d61-7vS9DEx5jTvaZifXW8CrTJmYnPA";
            string profileUrl = "";
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var response = await _httpClient.GetAsync(profileUrl);
            return await response.Content.ReadAsStringAsync();
        }
    }
}