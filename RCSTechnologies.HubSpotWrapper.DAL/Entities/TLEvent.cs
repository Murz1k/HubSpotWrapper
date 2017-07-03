using System;

namespace RCSTechnologies.HubSpotWrapper.DAL
{
    public class TLEvent
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public DateTime RecordTime { get; set; }

        public string Note { get; set; }
    }
}
