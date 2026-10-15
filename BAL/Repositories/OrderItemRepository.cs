using BAL.interfaces;
using BLLProject.Repositories;
using DAL;
using DAL.Data;
namespace BAL.Repositories
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(RestaurantAPIContext context) : base(context)
        {
        }
        public void RemoveRange(IEnumerable<OrderItem> entities)
        {
            dbContext.RemoveRange(entities);
        }

       
    }
}
