using Employee;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeXUnitTest
{
    public class OrderServiceTest
    {
        [Fact]
        public void GetOrderByIdInCorrectOrder()
        {
            //Arrange
            var mockRepo = new Mock<IOrderRepository>();
            mockRepo.Setup(repo => repo.GetbyId(1)).Returns(new Order { Id = 1, ProductName = "Test Product" });
            var service = new OrderService(mockRepo.Object);

            //Act
            var order = service.GetOrderById(1);
            //Assert
            Assert.Equal(1, order.Id);
            Assert.Equal("Test Product", order.ProductName);
        }
    }
}
