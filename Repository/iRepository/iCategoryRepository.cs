using UShopping.Models;

namespace UShopping.Repository.iRepository
{
    public interface ICategoryRepository : iRepository<Category>
    {
        void Update(Category obj);
    }
}