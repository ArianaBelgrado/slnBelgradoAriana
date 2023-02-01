using Microsoft.EntityFrameworkCore;
using slnBelgradoAriana.Models;

namespace slnBelgradoAriana.Data
{
    public class DbRecetasMVC : DbContext
    {
        public DbRecetasMVC(DbContextOptions<DbRecetasMVC> options) : base(options)
        {
        }
        public DbSet<Receta> Recetas{ get; set; }
    }
}
