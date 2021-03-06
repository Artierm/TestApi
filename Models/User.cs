using Newtonsoft.Json;


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

        public User(dynamic lastName, dynamic firstName, dynamic email)
        {
            FirstName = firstName.ToString();
            LastName = lastName.ToString();
            Email = email.ToString();
        }
    }
}

