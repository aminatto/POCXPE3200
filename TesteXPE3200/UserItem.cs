using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteXPE3200
{
    public class UserItem
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("UserID")]
        public string UserId { get; set; }

        [JsonProperty("FaceImage")]
        public string FaceImage { get; set; }

        public UserItem(string Name, string UserId, string FaceImage)
        {
            this.Name = Name;
            this.UserId = UserId;
            this.FaceImage = FaceImage;
        }
    }
}
