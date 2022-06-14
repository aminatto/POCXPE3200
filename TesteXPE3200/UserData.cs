using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteXPE3200
{
    public class UserData
    {
        [JsonProperty("item")]
        public IEnumerable<UserItem> Items { get; set; }

        public UserData(IEnumerable<UserItem> Itens)
        {
            this.Items = Itens;
        }
    }
}
