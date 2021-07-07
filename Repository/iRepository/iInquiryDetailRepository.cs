using UShopping.Models;

namespace UShopping.Repository.iRepository
{
    public interface iInquiryDetailRepository  : iRepository<InquiryDetail>
    {
        void Update(InquiryDetail obj);

       
    }
    
}