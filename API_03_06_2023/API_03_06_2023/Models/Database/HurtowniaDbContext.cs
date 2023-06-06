using Microsoft.EntityFrameworkCore;
using API_03_06_2023.Models.Hurtownia;
using MySqlConnector;

namespace API_03_06_2023.Models.Database
{
    public class HurtowniaDbContext : DbContext
    {
        private string _connectionString = new MySqlConnectionStringBuilder()
        {
            Server = "localhost",
            UserID = "root",
            Password = "",
            Database = "Hurtownia"
        }.ToString();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionString);
        }

        public DbSet<Client> klienci { get; set; }
    }
}
