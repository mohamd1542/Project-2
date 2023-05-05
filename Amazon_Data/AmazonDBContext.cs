using Amazon_Domain;
using Microsoft.EntityFrameworkCore;
using Task = Amazon_Domain.Task;

namespace Amazon_Data
{
    public class AmazonDBContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-73IK7RU\\SQLEXPRESS; Initial Catalog = AmazonDatabase");
        }
    } 
}