using System.Collections.Generic;

namespace RCSTechnologies.HubSpotWrapper.DAL
{
    public interface IHSContactService : IService<HSContact>
    {
        HSContact GetById(ulong id, string apiKey = "demo");

        IEnumerable<HSContact> SearchContactsByEmailOrNameOrCompanyName(string name, string apiKey = "demo");

        IEnumerable<HSContact> GetAll(ulong count = 0, string apiKey = "demo");
    }
}
