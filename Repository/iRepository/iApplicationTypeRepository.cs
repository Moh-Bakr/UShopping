using UShopping.Models;

namespace UShopping.Repository.iRepository
{
    public interface IApplicationTypeRepository : iRepository<ApplicationType>
    {
        void Update(ApplicationType obj);
    }
}