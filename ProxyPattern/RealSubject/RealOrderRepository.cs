using System;
using System.Collections.Generic;
using System.Linq;
using AdapterPattern.Models;
using ProxyPattern.Entities;
using ProxyPattern.SubjectBase;

namespace ProxyPattern.RealSubject
{
    public class RealOrderRepository : OrderRepositoryBase
    {
        private readonly List<PersonInfo> _customers = new List<PersonInfo>
        {
            new PersonInfo {FirstName = "Andrei", LastName = "Murug", Id = 1},
            new PersonInfo {FirstName = "Viorica", LastName = "Lazu", Id = 2}
        };

        private readonly Dictionary<int, int> _orderCustomers = new Dictionary<int, int>();

        private readonly List<OrderDetail> _orderDetails = new List<OrderDetail>
        {
            new OrderDetail {Description = "Order Item #1", Id = 1, OrderId = 1},
            new OrderDetail {Description = "Order Item #2", Id = 2, OrderId = 1},
            new OrderDetail {Description = "Order Item #1", Id = 3, OrderId = 2}
        };

        private readonly List<Order> _orders = new List<Order>
        {
            new Order {Id = 1, OrderDate = new DateTime(2016, 7, 17)},
            new Order {Id = 2, OrderDate = new DateTime(2016, 6, 16)}
        };


        public RealOrderRepository()
        {
            _orderCustomers.Add(1, 1);
            _orderCustomers.Add(2, 2);
        }

        public override Order GetOrder(int id)
        {
            var order = (from o in _orders where o.Id == id select o).SingleOrDefault();
            return order;
        }

        public override IEnumerable<OrderDetail> GetOrderDetails(int orderId)
        {
            var orderDetails =
                from o in _orderDetails
                where o.OrderId == orderId
                select o;
            return orderDetails;
        }

        public override PersonInfo GetOrderCustomer(int orderId)
        {
            var cutomerId = _orderCustomers[orderId];
            var customer = (from c in _customers where c.Id == cutomerId select c).SingleOrDefault();
            return customer;
        }
    }
}