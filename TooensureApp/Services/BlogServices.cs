using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TooensureApp.Models.BlogModel;
using TooensureApp.Services.IService;

namespace TooensureApp.Services
{
    public class BlogServices : IBlogService
    {
        private readonly HttpClient _httpClient;

        public BlogServices(HttpClient httpClient)
        {

            _httpClient = httpClient;
            

            Blogs = new List<Blog>();
        }

        public List<Blog> Blogs { get; set; }
        public string connectionString { get; } = "site-map/blog-feature/blogs.json";
        //Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        public async Task<IEnumerable<Blog>> GetAll()
        {
            var blogs = await _httpClient.GetFromJsonAsync<IEnumerable<Blog>>(connectionString);
            return blogs;
        }

        public async Task<Blog> GetById(int id)
        {
            var blogs = await this.GetAll();
            return blogs.ToList().Where(x =>x.Id == id).FirstOrDefault();
        }
    }
}