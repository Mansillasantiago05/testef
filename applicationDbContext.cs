using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{

   private  string path = "database.db"; //ruta de la base de datos
   public DbSet<Tarea> Tareas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //sobreescribimos el metodo OnConfiguring para configurar la base de datos
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite($"Data Source={path}");//es para crear la base de datos en sqlite
    }
}
//sqlite tiene la informacion para trabajar con la base de datos, que esquema y que informacion tiene, y el DbContext es el que se encarga de manejar la conexion con la base de datos y de hacer las operaciones CRUD (Create, Read, Update, Delete)