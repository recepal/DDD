using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Events
{
    public class OrderStartedDomainEvent : INotification // orderın başladıgını buyer ve ilgili taraflara bildiren event
    {
        public AggregateModels.OrderModels.Order Order { get; set; }
        public string UserName { get; set; }

        public OrderStartedDomainEvent(string userName, AggregateModels.OrderModels.Order order)
        {
            UserName = userName;
            Order = order;
        }
    }
}
