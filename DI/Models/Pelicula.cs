using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Models
{
    [Table("PELICULAS")]
    public class Pelicula
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPelicula { get; set; }
        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("DIRECTOR")]
        public String Director { get; set; }
        [Column("CLASIFICACION")]
        public String Clasificacion { get; set; }
    }
}
