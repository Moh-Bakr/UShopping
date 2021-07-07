using UShopping.Data;
using UShopping.Models;
using UShopping.Repository.iRepository;


namespace UShopping.Repository
{ public class OrderHeaderRepository: Repository<OrderHeader>,  IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.OrderHeaders.Update(obj);
        }
        
    }
}