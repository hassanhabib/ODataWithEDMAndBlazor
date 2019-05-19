using BlazorPagination.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorPagination.Data
{
    public class StudentsService
    {
        public async Task<StudentsApiResponse> GetStudentsAsync(int skip = 0, int top = 0)
        {
            string baseUrl = "https://localhost:44374";
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"{baseUrl}/api/students?$orderby=Name&$count=true&$skip={skip}&$top={top}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<StudentsApiResponse>(jsonString);
                }

                return new StudentsApiResponse();
            }
        }
    }
}
