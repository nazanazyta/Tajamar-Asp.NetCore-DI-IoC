using DI.Data;
using DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Repositories
{
    public class RepositorySql : IRepository
    {
        PruebasContext context;

        public RepositorySql(PruebasContext context)
        {
            this.context = context;
        }

        public List<Pelicula> BuscarPeliculas()
        {
            return this.context.Peliculas.ToList();
        }

        public Pelicula BuscarPeliculaPorId(int id)
        {
            return this.context.Peliculas.SingleOrDefault(x => x.IdPelicula == id);
        }
    }
}
