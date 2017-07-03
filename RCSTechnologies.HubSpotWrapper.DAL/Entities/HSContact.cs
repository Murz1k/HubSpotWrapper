using Newtonsoft.Json;
using System;

namespace RCSTechnologies.HubSpotWrapper.DAL
{
    public class HSContact
    {
        public HSContact()
        {
            Properties = new HSProperty();
        }

        [JsonProperty(PropertyName = "vid")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "canonical-vid")]
        public long CanonicalId { get; set; }

        [JsonProperty(PropertyName = "portal-id")]
        public long PortalId { get; set; }

        [JsonProperty(PropertyName = "is-contact")]
        public bool IsContact { get; set; }

        [JsonProperty(PropertyName = "profile-token")]
        public string ProfileToken { get; set; }

        [JsonProperty(PropertyName = "profile-url")]
        public string ProfileUrl { get; set; }

        [JsonProperty(PropertyName = "properties")]
        internal HSProperty Properties {get;set;}

        public string Email { get { return Properties.Email.Value; } set { Properties.Email.Value = value; } }

        public string Website { get { return Properties.Website.Value; } set { Properties.Website.Value = value; } }

        public string Company { get { return Properties.Company.Value; } set { Properties.Company.Value = value; } }

        public string Phone { get { return Properties.Phone.Value; } set { Properties.Phone.Value = value; } }

        public string Address { get { return Properties.Address.Value; } set { Properties.Address.Value = value; } }

        public string City { get { return Properties.City.Value; } set { Properties.City.Value = value; } }

        public string State { get { return Properties.State.Value; } set { Properties.State.Value = value; } }

        public string Zip { get { return Properties.Zip.Value; } set { Properties.Zip.Value = value; } }

        public string FirstName { get { return Properties.FirstName.Value; } set { Properties.FirstName.Value = value; } }

        public string LastName { get { return Properties.LastName.Value; } set { Properties.LastName.Value = value; } }

        public DateTime LastModifiedDate { get { return (Properties.LastModifiedDate.Value=="" ? default(DateTime) : new DateTime(long.Parse(Properties.LastModifiedDate.Value))); } set { Properties.LastModifiedDate.Value = value.Ticks.ToString(); } }

        public DateTime CreateDate { get { return (Properties.CreateDate.Value == "" ? default(DateTime) : new DateTime(long.Parse(Properties.CreateDate.Value))); } set { Properties.CreateDate.Value = value.Ticks.ToString(); } }

        //"merged-vids":[],
        //"properties":{},
        //"form-submissions":[],
        //"identity-profiles":[],
        //"merge-audits":
    }
}
