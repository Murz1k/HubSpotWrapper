using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RCSTechnologies.HubSpotWrapper.DAL
{
    public class TLEventTypeService : ITLEventTypeService
    {
        private HttpClient _client;
        private long _appId;
        private long _userId;

        public TLEventTypeService(long appId, long userId)
        {
            _client = new HttpClient();
            _appId = appId;
            _userId = userId;
        }

        public void Add(TLEventType item, string apiKey = "demo")
        {
            item.ApplicationId = _appId;
            dynamic createEventType = new {name = item.Name, applicationId = _appId }; 
            string url = "https://api.hubapi.com/integrations/v1/" + _appId + "/timeline/event-types?hapikey=" + apiKey + "&userId=" + _userId;
            HttpContent content = new StringContent(JsonConvert.SerializeObject(createEventType), Encoding.UTF8, "application/json");
            Task.Run(async () => await _client.PostAsync(url, content));
        }

        public void Delete(long id, string apiKey = "demo")
        {
            throw new NotImplementedException();
        }

        public void Edit(TLEventType item, string apiKey = "demo")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TLEventType> GetAll(string apiKey = "demo")
        {
            string url = "https://api.hubapi.com/integrations/v1/" + _appId + "/timeline/event-types?hapikey=" + apiKey + "&userId=" + _userId;
            string result = Task.Run(async () => await _client.GetStringAsync(url)).Result;
            return JsonConvert.DeserializeObject<IEnumerable<TLEventType>>(result);
        }
    }
}
