using ApiFeria.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiFeria.Data
{
    public class AlumnoContext : DbContext
    {
        public AlumnoContext(DbContextOptions<AlumnoContext> options) : base(options)
        {

        }

        public DbSet<Alumno> alumnos { get; set; }
    }
}
