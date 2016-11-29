using System;
using System.Collections.Generic;
using AdapterPattern.Models;

namespace ProxyPattern.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public PersonInfo Customer { get; set; }
        public IEnumerable<OrderDetail> Details { get; set; }
    }
}