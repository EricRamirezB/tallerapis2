using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TallerApis.Apis.Models
{
    [Table("Publicaciones")]
    public class Publicacion
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(200)]
        public string Descripcion { get; set; }

        [Required]
        public string FechaPublicacion { get; set; }

        public int MeGusta { get; set; }

        public int MeDiGusta { get; set; }

        public int VecesCompartido { get; set; }

        public bool EsPrivada { get; set; }

    }
}

