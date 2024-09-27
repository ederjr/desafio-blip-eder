using System.Text.Json.Serialization;

namespace APIDesafioBlip.Models
{
    public partial class Owner
    {
        [JsonPropertyName("html_url")]
        public Uri HtmlUrl { get; set; }
    }
    public class Repository
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("private")]
        public bool Private { get; set; }

        [JsonPropertyName("owner")]
        public Owner Owner { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("html_url")]
        public Uri HtmlUrl { get; set; }
    }
}