using System;
using System.Collections.Generic;
using System.Text;

namespace TallerApis.Xamarin.Models
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Descripcion { get; set; }
        public string FechaPublicacion { get; set; }
        public int MeGusta { get; set; }
        public int MeDiGusta { get; set; }
        public int VecesCompartido { get; set; }
        public bool EsPrivada { get; set; }
    }
}


