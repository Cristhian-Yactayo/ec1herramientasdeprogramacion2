using api_empresa.Entitys;
using Microsoft.EntityFrameworkCore;

namespace api_empresa
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        //configurando las tablas de la base de datos
        public DbSet<Empresa> Empresa { get; set; }
    }
}
