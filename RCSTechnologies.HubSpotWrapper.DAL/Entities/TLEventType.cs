using Newtonsoft.Json;

namespace RCSTechnologies.HubSpotWrapper.DAL
{
    public class TLEventType
    {
        public TLEventType()
        {
            Properties = new HSProperty();
        }

        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "headerTemplate")]
        public string HeaderTemplate { get; set; }

        [JsonProperty(PropertyName = "detailTemplate")]
        public string DetailTemplate { get; set; }

        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

        [JsonProperty(PropertyName = "applicationId")]
        public long ApplicationId { get; set; }

        [JsonProperty(PropertyName = "properties")]
        internal HSProperty Properties { get; set; }
    }
}
