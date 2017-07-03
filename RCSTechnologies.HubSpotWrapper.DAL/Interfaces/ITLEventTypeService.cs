using System.Collections.Generic;

namespace RCSTechnologies.HubSpotWrapper.DAL
{
    public interface ITLEventTypeService : IService<TLEventType>
    {
        IEnumerable<TLEventType> GetAll(string apiKey = "demo");
    }
}
