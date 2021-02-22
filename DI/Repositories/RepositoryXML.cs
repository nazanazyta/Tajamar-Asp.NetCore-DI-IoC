using DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DI.Repositories
{
    public class RepositoryXML : IRepository
    {
        XDocument docxml;

        public RepositoryXML()
        {
            this.docxml = XDocument.Load("N:/peliculas.xml");
        }

        public List<Pelicula> BuscarPeliculas()
        {
            var consulta = from datos in this.docxml.Descendants("PELICULA")
                           select new Pelicula{
                               IdPelicula = int.Parse(datos.Element("ID").Value),
                               Nombre = datos.Element("NOMBRE").Value,
                               Director = datos.Element("DIRECTOR").Value,
                               Clasificacion = datos.Element("CLASIFICACION").Value};
            return consulta.ToList();
        }

        public Pelicula BuscarPeliculaPorId(int id)
        {
            var consulta = from datos in this.docxml.Descendants("PELICULA")
                           where datos.Element("ID").Value == id.ToString()
                           select new Pelicula{
                               IdPelicula = int.Parse(datos.Element("ID").Value),
                               Nombre = datos.Element("NOMBRE").Value,
                               Director = datos.Element("DIRECTOR").Value,
                               Clasificacion = datos.Element("CLASIFICACION").Value};
            return consulta.FirstOrDefault();
        }
    }
}
