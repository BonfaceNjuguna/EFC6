using EFC6.Ch2.FitnessApp.Domain;
using Microsoft.EntityFrameworkCore;

public class FitnessAppContext : DbContext
{
	public DbSet<RunActivity> runActivity { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server = localhost\\SQLEXPRESS; Database=FitnessDb; Trusted_Connection = True;"
            );
    }
}
