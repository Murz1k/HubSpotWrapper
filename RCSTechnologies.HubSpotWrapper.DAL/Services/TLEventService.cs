using System;
using System.Net.Http;

namespace RCSTechnologies.HubSpotWrapper.DAL
{
    public class TLEventService : ITLEventService
    {
        private HttpClient _client;

        public TLEventService()
        {
            _client = new HttpClient();
        }

        public void Add(TLEvent item, string apiKey = "demo")
        {
            //string url = "https://api.hubapi.com/contacts/v1/contact/?hapikey=" + _apiKey;
            //HttpContent content = new StringContent(JsonConvert.SerializeObject(item.Properties),
            //    Encoding.UTF8, "application/json");
            //Task.Run(async () => await _client.PostAsync(url, content));
        }

        public void Delete(long id, string apiKey = "demo")
        {
            throw new NotImplementedException();
        }

        public void Edit(TLEvent item, string apiKey = "demo")
        {
            throw new NotImplementedException();
        }
    }
}
