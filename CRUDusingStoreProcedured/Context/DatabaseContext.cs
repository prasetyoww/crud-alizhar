using CRUDusingStoreProcedured.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDusingStoreProcedured.Context
{
    public class DatabaseContext : DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Data Source=DESKTOP-59QQ5M9;Initial Catalog=EmployeeDB;Integrated Security=True");
            options.UseSqlServer(connectionString);
        }

        public DbSet<Karyawan> Karyawans { get; set; }
    }
}
