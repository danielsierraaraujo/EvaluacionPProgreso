using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvaluacionPProgreso.Models;

namespace EvaluacionPProgreso.Data 
{
    public class DanielSierraDBEvaluacionPProgreso : DbContext
    {
        public DanielSierraDBEvaluacionPProgreso(DbContextOptions<DanielSierraDBEvaluacionPProgreso> options)
            : base(options)
        {
        }

        public DbSet<Dueno> Dueno { get; set; } = default!;
        public DbSet<Mascota> Mascota { get; set; } = default!;
        public DbSet<Cita> Cita { get; set; } = default!;
    }
}
