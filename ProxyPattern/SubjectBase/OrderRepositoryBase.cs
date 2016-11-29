using System.Collections.Generic;
using AdapterPattern.Models;
using ProxyPattern.Entities;

namespace ProxyPattern.SubjectBase
{
    public abstract class OrderRepositoryBase
    {
        public abstract Order GetOrder(int id);

        public abstract IEnumerable<OrderDetail> GetOrderDetails(int orderId);

        public abstract PersonInfo GetOrderCustomer(int orderId);
    }
}