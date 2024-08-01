using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40_Interfaces
{
    public class OrderService : IOrderService
    {
        private readonly List<IMyLogger> _loggers;
        public OrderService(IEnumerable<IMyLogger> logger)// Priklausomybių injekcija per konstruktorių
        {
            _loggers = new List<IMyLogger> (logger);
        }

        public Order PlaceOrder()
        {
            // Kažkokia biznio logika
            var order = new Order(0.1, 100);
            Log($"Order has been placed. Price={order.Price}, Ammount={order.Amount} ");
            return order;
        }

        private void Log(string message) => _loggers.ForEach(logger => logger.Log(message));
    }
}
