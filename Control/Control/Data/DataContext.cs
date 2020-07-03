
namespace Control.Data
{
    using Control.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    public class DataContext:DbContext
    {
        public DbSet<Alumno> Alumnos { set; get; }
        public DataContext(DbContextOptions<DataContext>options): base(options)
        {

        }
    }
}
