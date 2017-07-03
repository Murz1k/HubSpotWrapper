namespace RCSTechnologies.HubSpotWrapper.DAL
{
    public interface IService<T> where T:class
    {
        void Add(T item, string apiKey = "demo");

        void Edit(T item, string apiKey = "demo");

        void Delete(long id, string apiKey = "demo");
    }
}
