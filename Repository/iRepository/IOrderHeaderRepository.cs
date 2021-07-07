using UShopping.Models;

namespace UShopping.Repository.iRepository
{
    public interface IOrderHeaderRepository : iRepository<OrderHeader>
    {
        void Update(OrderHeader obj);
    }
}