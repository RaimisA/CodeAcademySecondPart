using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P40_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40_Interfaces.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            // Arrange
            var logger = new TestingLogger();
            var orderService = new OrderService(logger);

            // Act
            var order = orderService.PlaceOrder();

            // Assert
            Assert.AreEqual(0.1, order.Price);
            Assert.AreEqual(100, order.Amount);
        }
        [TestMethod()]
        public void CombinedPlaceOrderTest()
        {
            // Arrange
            var loggers = new List<IMyLogger>
            {
                new ConsoleMyLogger(),
                new FileMyLogger()
            };
            var logger = new TestingLogger();
            var orderService = new OrderService(logger);

            // Act
            var order = orderService.PlaceOrder();

            // Assert
            Assert.AreEqual(0.1, order.Price);
            Assert.AreEqual(100, order.Amount);
        }
    }
}