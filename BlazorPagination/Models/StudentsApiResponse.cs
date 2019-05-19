using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlazorPagination.Models
{
    public class StudentsApiResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public List<Student> Students { get; set; }
    }
}
