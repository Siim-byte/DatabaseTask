using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalVisit> MedicalVisits { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
    }
}
