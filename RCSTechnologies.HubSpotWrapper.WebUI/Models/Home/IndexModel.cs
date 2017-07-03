using RCSTechnologies.HubSpotWrapper.DAL;
using System.Collections.Generic;

namespace RCSTechnologies.HubSpotWrapper.WebUI.Models
{
    public class IndexModel
    {
        public IEnumerable<HSContact> Contacts { get; set; }
    }
}
