﻿using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;

namespace SwapiMVC.Models
{
    public class ResultsViewModel<TResult> 
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("next")]
        public string Next { get; set; }
        [JsonPropertyName("previous")]
        public string Previous { get; set; }
        [JsonPropertyName("results")]
        public IEnumerable<TResult> Results { get; set; }

        public string NextPageNum => Next?.Split("?page=").LastOrDefault();
        public string PreviousPageNum => Previous?.Split("?page=").LastOrDefault();
    }
}
