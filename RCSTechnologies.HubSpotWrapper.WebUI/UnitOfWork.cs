using System;

namespace RCSTechnologies.HubSpotWrapper.WebUI
{
    public class UnitOfWork : IUnitOfWork
    {
        private IServiceProvider _provider;

        public UnitOfWork(IServiceProvider provider)
        {
            _provider = provider;
        }

        public T Get<T>() where T : class
        {
            return (T)_provider.GetService(typeof(T));
        }
    }
}
