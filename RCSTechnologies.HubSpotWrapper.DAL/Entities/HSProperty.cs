using Newtonsoft.Json;

namespace RCSTechnologies.HubSpotWrapper.DAL
{
    public class HSProperty
    {
        public HSProperty()
        {
            FirstName = new HsPropertyField();
            LastModifiedDate = new HsPropertyField();
            LastName = new HsPropertyField();
            CreateDate = new HsPropertyField();
            State = new HsPropertyField();
            Zip = new HsPropertyField();
            Phone = new HsPropertyField();
            FollowerCount = new HsPropertyField();
            City = new HsPropertyField();
            TwitterId = new HsPropertyField();
            Company = new HsPropertyField();
            Email = new HsPropertyField();
            Website = new HsPropertyField();
            Address = new HsPropertyField();
            Photo = new HsPropertyField();
            TwitterProfilePhoto = new HsPropertyField();
            LifeCycleStage = new HsPropertyField();
        }

        [JsonProperty(PropertyName = "firstname")]
        public HsPropertyField FirstName { get; set; }

        [JsonProperty(PropertyName = "lastmodifieddate")]
        public HsPropertyField LastModifiedDate { get; set; }

        [JsonProperty(PropertyName = "lastname")]
        public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_last_url")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "lead_source")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "num_unique_conversion_events")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_revenue")]
        //public HsPropertyField LastName { get; set; }

        [JsonProperty(PropertyName = "createdate")]
        public HsPropertyField CreateDate { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_first_referrer")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_email_optout")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_predictivecontactscore")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "annualrevenue")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_num_page_views")]
        //public HsPropertyField LastName { get; set; }

        [JsonProperty(PropertyName = "state")]
        public HsPropertyField State { get; set; }

        [JsonProperty(PropertyName = "zip")]
        public HsPropertyField Zip { get; set; }

        //[JsonProperty(PropertyName = "fortune_rank")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_predictivecontactscorebucket")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hubspotscore")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "linkedinconnections")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_lifecyclestage_subscriber_date")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_average_page_views")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "twitterhandle")]
        //public HsPropertyField LastName { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public HsPropertyField Phone { get; set; }

        //[JsonProperty(PropertyName = "num_conversion_events")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "currentlyinworkflow")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_num_event_completions")]
        //public HsPropertyField LastName { get; set; }

        [JsonProperty(PropertyName = "followercount")]
        public HsPropertyField FollowerCount { get; set; }

        //[JsonProperty(PropertyName = "hs_email_optout_2849")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "associatedcompanyid")]
        //public HsPropertyField LastName { get; set; }

        [JsonProperty(PropertyName = "city")]
        public HsPropertyField City { get; set; }

        //[JsonProperty(PropertyName = "hs_email_optout_354586")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_social_num_broadcast_clicks")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_last_timestamp")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_num_visits")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "twitterbio")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_social_linkedin_clicks")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_last_visit_timestamp")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_social_last_engagement")]
        //public HsPropertyField LastName { get; set; }

        [JsonProperty(PropertyName = "hs_twitterid")]
        public HsPropertyField TwitterId { get; set; }

        //[JsonProperty(PropertyName = "associatedcompanylastupdated")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_source")]
        //public HsPropertyField LastName { get; set; }

        [JsonProperty(PropertyName = "company")]
        public HsPropertyField Company { get; set; }

        [JsonProperty(PropertyName = "email")]
        public HsPropertyField Email { get; set; }

        //[JsonProperty(PropertyName = "linkedinbio")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_first_url")]
        //public HsPropertyField LastName { get; set; }

        [JsonProperty(PropertyName = "website")]
        public HsPropertyField Website { get; set; }

        [JsonProperty(PropertyName = "address")]
        public HsPropertyField Address { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_first_visit_timestamp")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_first_timestamp")]
        //public HsPropertyField LastName { get; set; }

        [JsonProperty(PropertyName = "photo")]
        public HsPropertyField Photo { get; set; }

        //[JsonProperty(PropertyName = "hs_social_google_plus_clicks")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_last_referrer")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "kloutscoregeneral")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_email_optout_230318")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_social_facebook_clicks")]
        //public HsPropertyField LastName { get; set; }

        [JsonProperty(PropertyName = "twitterprofilephoto")]
        public HsPropertyField TwitterProfilePhoto { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_source_data_2")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_social_twitter_clicks")]
        //public HsPropertyField LastName { get; set; }

        //[JsonProperty(PropertyName = "hs_analytics_source_data_1")]
        //public HsPropertyField LastName { get; set; }

        [JsonProperty(PropertyName = "lifecyclestage")]
        public HsPropertyField LifeCycleStage { get; set; }

        //[JsonProperty(PropertyName = "hs_email_sends_since_last_engagement")]
        //public HsPropertyField LastName { get; set; }
    }

    public class HsPropertyField
    {
        private string _value;
        [JsonProperty(PropertyName = "value")]
        public string Value { get { return _value == null ? "" : _value; } set { _value = value; } }
    }
}
