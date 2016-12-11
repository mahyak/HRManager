using System.Data.Entity;
using System.Web.Configuration;

namespace HRManager.Models
{
    public class HRManagerDbContext:DbContext
    {
        public HRManagerDbContext() : base(WebConfigurationManager.ConnectionStrings["HRContext"].ConnectionString) { }
        public DbSet<Person> Person { get; set; }
        public DbSet<City> City { get; set; }
    }
}