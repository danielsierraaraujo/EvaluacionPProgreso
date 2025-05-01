using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvaluacionPProgreso.Models;

    public class DanielSierraDBEvaluacionPProgreso : DbContext
    {
        public DanielSierraDBEvaluacionPProgreso (DbContextOptions<DanielSierraDBEvaluacionPProgreso> options)
            : base(options)
        {
        }

        public DbSet<EvaluacionPProgreso.Models.Dueno> Dueno { get; set; } = default!;

public DbSet<EvaluacionPProgreso.Models.Mascota> Mascota { get; set; } = default!;

public DbSet<EvaluacionPProgreso.Models.Cita> Cita { get; set; } = default!;
    }
