

namespace MVC_Address.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
            
        }

        public System.Data.Entity.DbSet<MVC_Address.Models.Book> Books { get; set; }
    }
}