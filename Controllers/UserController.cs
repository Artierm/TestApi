using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TestApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<string> GetAsync()
        {
            const string GETUSER_URL = "https://dummyapi.io/data/api/user?limit=10";
            const string appId = "60630884ce28c8d3a5d836e3";
            using var getUsers = new HttpClient();
            getUsers.DefaultRequestHeaders.Add("app-id", appId);
            var result = await getUsers.GetStringAsync(GETUSER_URL);
            dynamic json = JsonConvert.DeserializeObject(result);
            var data = json.data;
            List<User> users = new List<User>();
            foreach (var values in data)
            {
                User user = new User(values.id.ToString(), values.lastName.ToString(), values.firstName.ToString(), values.email.ToString());
                users.Add(user);
            }
            string output = JsonConvert.SerializeObject(users, Formatting.Indented);
            return output;
        }
    }
}
