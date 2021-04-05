using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class User
    {

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        public User(string lastName, string firstName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}

