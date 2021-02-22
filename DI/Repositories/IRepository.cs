using DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Repositories
{
    public interface IRepository
    {
        List<Pelicula> BuscarPeliculas();
        Pelicula BuscarPeliculaPorId(int id);
    }
}
