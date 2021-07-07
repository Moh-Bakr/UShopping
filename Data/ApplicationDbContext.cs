using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UShopping.Models;

namespace UShopping.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        } 
        public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }
        public DbSet<Product> Product { get; set; }
       public DbSet<ApplicationUser> ApplicationUser { get; set; }
       
       public DbSet<InquiryHeader> InquiryHeader { get; set; }
       public DbSet<InquiryDetail> InquiryDetail { get; set; }
       
       public DbSet<OrderHeader> OrderHeaders { get; set; }
       
       public DbSet<OrderDetail> OrderDetails { get; set; }


    }
}