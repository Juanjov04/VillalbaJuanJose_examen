using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VillalbaJuanJose_examen.Models;

    public class JVillalbacontext : DbContext
    {
        public JVillalbacontext (DbContextOptions<JVillalbacontext> options)
            : base(options)
        {
        }

        public DbSet<VillalbaJuanJose_examen.Models.JVillalba> JVillalba { get; set; } = default!;
    }
