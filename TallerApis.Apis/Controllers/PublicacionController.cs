using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TallerApis.Apis.Models;

namespace TallerApis.Apis.Controllers
{
    public class PublicacionController : ApiController
    {

        [HttpGet]
        public IEnumerable<Publicacion> Get()
        {
            using (var context = new PublicacionContext())
            {
                return context.Publicacion.ToList();
            }
        }






    }
}
