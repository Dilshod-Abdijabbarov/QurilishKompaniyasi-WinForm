
using QurilishKompaniyasi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace QurilishKompaniyasi1.Data
{
    public class ModelDbContext : DbContext
    {
        //private static readonly string ConnectionString = "Server=DESKTOP-CJI1HH3\\SQLEXPRESS;Database=QurilishKompaniyasi;Trusted_Connection=True;";
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer(@"Data Source=Server=(localdb)Sqllocaldb;Initial Catalog=DbQurilishKompaniya;");
        // }

        public ModelDbContext() : base("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;")
        {

        }
        DbSet<Product> Products { get; set; }

        public DbSet <Order> Orders { get; set; }

        public DbSet<Deficit> Deficits { get; set; }
    }
}
