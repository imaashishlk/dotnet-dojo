using BilletHub.Application.IRepositories;
using BilletHub.Application.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilletHub.Application.Services
{
    public class OrderService(IOrderRepository orderRepository) : IOrderService
    {
    }
}
