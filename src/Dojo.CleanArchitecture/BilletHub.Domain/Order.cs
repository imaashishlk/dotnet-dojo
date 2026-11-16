using System;
using System.Collections.Generic;
using System.Text;

namespace BilletHub.Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid EventId { get; set; }
        public Guid TicketTypeId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public OrderStatus Status { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Confirmed,
        Cancelled
    }
}
