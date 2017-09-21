using System;
using Newtonsoft.Json;

namespace TestRefit.Network
{
    public class Item
    {
		[JsonProperty(PropertyName = "title")]
        public string title { get; set; }

        [JsonProperty(PropertyName = "href")]
        public string url { get; set; }


    }
}
