using System;
using Newtonsoft.Json;

namespace HistoricalMysteryAPI.Contracts
{
    public class ArticleItem
    {
        [JsonProperty]
        public int ArticleId { get; set; }

        [JsonProperty]
        public int ArticleAuthorId { get; set; }

        [JsonProperty]
        public int ArticleCollectionId { get; set; }

        [JsonProperty]
        public string ArticleTag { get; set; }

        [JsonProperty]
        public string ArticleFeatureImage { get; set; }

        [JsonProperty]
        public string ArticleDisplayTitle { get; set; }

        [JsonProperty]
        public string ArticleDisplaySubtitle { get; set; }

        [JsonProperty]
        public DateTime ArticleUpdateTime { get; set; }

        [JsonProperty]
        public int ArticleReadTime { get; set; }

        [JsonProperty]
        public string UserFirstName { get; set; }

        [JsonProperty]
        public string UserLastName { get; set; }
    }
}
