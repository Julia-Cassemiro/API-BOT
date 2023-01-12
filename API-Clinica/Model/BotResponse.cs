using Newtonsoft.Json;



namespace API_Clinica.Model
{
    public class Credentials_Response
    {

        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("text")]

        public string Text { get; set; }
        public Attachments Attachments { get; set; }


    }

    public class Attachments
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
