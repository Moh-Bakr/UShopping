using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using UShopping.Models;

namespace UShopping.Repository.iRepository
{
    public interface IProductRepository : iRepository<Product>
    {
        void Update(Product obj);

        IEnumerable<SelectListItem> GetAllDropdownList(string obj);
    }
}