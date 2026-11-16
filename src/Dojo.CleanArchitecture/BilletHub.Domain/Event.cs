using System;
using System.Collections.Generic;
using System.Text;

namespace BilletHub.Domain
{
    public class Event
    {
        public Guid Id { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventDate { get; set; }
        public EventStatus Status { get; set; }
    }

    public enum EventStatus
    {
        Active,
        Inactive
    }
}
