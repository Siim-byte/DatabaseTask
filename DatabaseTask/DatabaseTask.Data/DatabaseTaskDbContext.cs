using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Absense> Absenses { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<ChildGroupHistory> ChildGroupHistories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Queue> Queues { get; set; }
    }
}
