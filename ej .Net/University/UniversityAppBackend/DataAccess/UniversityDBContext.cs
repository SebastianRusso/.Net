using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using UniversityAppBackend.Models.DataModels;

namespace UniversityAppBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext (DbContextOptions<UniversityDBContext> options) : base(options) {
        
        }

        // todo: add  DBsets (tables of our data base)

        public DbSet<Curso>? Cursos { get; set; }   

    }
}
