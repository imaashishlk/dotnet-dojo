using System;
using System.Collections.Generic;
using System.Text;

namespace BilletHub.Domain
{
    public class TicketType
    {
        public Guid Id { get; set; }
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
