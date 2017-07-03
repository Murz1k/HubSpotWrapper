using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSTechnologies.HubSpotWrapper.DAL
{
    public class HSResponse
    {
        public IEnumerable<HSContact> Contacts { get; set; }
    }
}
