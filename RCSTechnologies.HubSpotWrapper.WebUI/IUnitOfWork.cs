using System;

namespace RCSTechnologies.HubSpotWrapper.WebUI
{
    public interface IUnitOfWork
    {
        T Get<T>() where T: class;
    }
}
