using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace WinFormsApp6;

public class CarContex:DbContext
{
    public DbSet<Car> Cars { get; set; }
    public CarContex()
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Integrated Security = SSPI; Database = Cars;");

    }
}
