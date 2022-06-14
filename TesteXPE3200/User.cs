using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteXPE3200
{
    public class User
    {
        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public UserData Data { get; set; }

        public User(string target, string action, IEnumerable<UserItem> items)
        {
            Target = target;
            Action = action;
            Data = new UserData(items);
        }
    }
}
