using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VillalbaJuanJose_examen.Models;

    public class Celularcontext : DbContext
    {
        public Celularcontext (DbContextOptions<Celularcontext> options)
            : base(options)
        {
        }

        public DbSet<VillalbaJuanJose_examen.Models.Celular> Celular { get; set; } = default!;
    }
