using BAL.interfaces;
using BLLProject.Repositories;
using BLLProject.Specifications;
using DAL;
using DAL.Data;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
namespace BAL.Repositories
{
    class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(RestaurantAPIContext context) : base(context)
        {
        }
        public void UpdatePaymentStatus(int id, PaymentStatus paymentStatus)
        {
            var OrderFromDb = dbContext.Order.FirstOrDefault(x => x.id == id);
            var paymentMethod = dbContext.Payment.FirstOrDefault(x => x.OrderId == id);
            if (OrderFromDb != null)
            {
                if (paymentMethod != null)
                {
                    paymentMethod.PaymentTime = DateTime.Now;
                }
                OrderFromDb.PaymentStatus = paymentStatus;
            }
        }

        public void UpdateOrderStatus(int id, OrderStatus orderStatus)
        {
            var OrderFromDb = dbContext.Order.FirstOrDefault(x => x.id == id);
            if (OrderFromDb != null)
                OrderFromDb.OrderStatus = orderStatus;
        }
    }
}
