using UShopping.Data;
using UShopping.Models;
using UShopping.Repository.iRepository;

namespace UShopping.Repository
{
   
    public class InquiryDetailRepository : Repository<InquiryDetail>, iInquiryDetailRepository
    {
        private readonly ApplicationDbContext _db;
        public InquiryDetailRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(InquiryDetail obj)
        {
            _db.InquiryDetail.Update(obj);
        }
    }
}