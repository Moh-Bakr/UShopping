using UShopping.Models;

namespace UShopping.Repository.iRepository
{
    public interface IOrderDetailRepository : iRepository<OrderDetail>
    {
        void Update(OrderDetail obj);
        
    }
}