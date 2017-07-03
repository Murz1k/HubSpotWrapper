using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RCSTechnologies.HubSpotWrapper.DAL
{
    public class HSContactService : IHSContactService
    {
        private HttpClient _client;

        public HSContactService()
        {
            _client = new HttpClient();
        }

        public void Add(HSContact item, string apiKey = "demo")
        {
            string url = "https://api.hubapi.com/contacts/v1/contact/?hapikey=" + apiKey;
            dynamic contact = new { properties = new dynamic[]{
                new {property = "email", value = "testingapis@hubspot.com" },
                new {property = "firstname", value = "Max89701" },
                new {property = "lastname", value = "Mott" },
                new {property = "website", value = "http://hubspot.com" },
                new {property = "company", value = "HubSpot" },
                new {property = "phone", value = "555-122-2323" },
                new {property = "address", value = "25 First Street" },
                new {property = "city", value = "Cambridge" },
                new {property = "state", value = "MA" },
                new {property = "zip", value = "02139" }
            } };
            HttpContent content = new StringContent(JsonConvert.SerializeObject(contact), 
                Encoding.UTF8, "application/json");
            Task.Run(async()=> await _client.PostAsync(url, content));
        }

        public HSContact GetById(ulong id, string apiKey = "demo")
        {
            string url = "https://api.hubapi.com/contacts/v1/contact/vid/" + id + "/profile?hapikey=" + apiKey;
            string result = Task.Run(async () => await _client.GetStringAsync(url)).Result;
            return JsonConvert.DeserializeObject<HSContact>(result);
        }

        public IEnumerable<HSContact> GetAll(ulong count = 0, string apiKey = "demo")
        {
            string url = "https://api.hubapi.com/contacts/v1/lists/all/contacts/all?hapikey=" + apiKey + (count > 0 ? "&count=" + count : "");
            string result = Task.Run(async () => await _client.GetStringAsync(url)).Result;
            return JsonConvert.DeserializeObject<HSResponse>(result).Contacts;
        }

        public void Delete(long id, string apiKey = "demo")
        {
            string url = "https://api.hubapi.com/contacts/v1/contact/vid/" + id + "?hapikey=" + apiKey;
            Task.Run(async () => await _client.DeleteAsync(url));
        }

        public IEnumerable<HSContact> SearchContactsByEmailOrNameOrCompanyName(string name, string apiKey = "demo")
        {
            string url = "https://api.hubapi.com/contacts/v1/search/query?q="+ name+"&hapikey=" + apiKey;
            string result = Task.Run(async () => await _client.GetStringAsync(url)).Result;
            return JsonConvert.DeserializeObject<HSResponse>(result).Contacts;

        }

        public void Edit(HSContact item, string apiKey = "demo")
        {
            throw new NotImplementedException();
        }
    }
}
