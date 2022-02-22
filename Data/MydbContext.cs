



using Microsoft.EntityFrameworkCore;
using WebAppMVCCore6.Models;

namespace WebAppMVCCore6.Data
{
    public class MydbContext:DbContext
    {
        public MydbContext(DbContextOptions<MydbContext> options)
: base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Produit> Produit { get; set; }
    }
}
    

