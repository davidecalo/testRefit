using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TestRefit.Network
{
    public class RecipeResponse
    {
        [JsonProperty(PropertyName = "results")]
        public List<Item> Items { get; set; }
    }

}
