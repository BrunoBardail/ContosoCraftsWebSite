﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCraftsWebSite.wwwroot.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        [JsonPropertyName("img")]
        public string image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ratings { get; set; }


        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}
