using DI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Data
{
    public class PruebasContext: DbContext
    {
        public PruebasContext(DbContextOptions<PruebasContext> options)
            : base(options) { }
        
        public DbSet<Pelicula> Peliculas { get; set; }
    }
}