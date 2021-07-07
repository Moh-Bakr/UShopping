using UShopping.Models;

namespace UShopping.Repository.iRepository
{
   
    public interface IInquiryHeaderRepository : iRepository<InquiryHeader>
    {
        void Update(InquiryHeader obj);

       
    }
}