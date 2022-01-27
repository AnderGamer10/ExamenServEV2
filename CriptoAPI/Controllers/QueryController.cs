using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cripto.Models;

namespace CriptoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        private readonly CryptoContext db;

        public QueryController(CryptoContext context)
        {
            db = context;
        }

        [HttpGet("0")]
        public ActionResult Query0(int ValorActual = 50)
        {
            // Ejemplo de método en controlador
            var list = db.Moneda.ToListAsync();

            return Ok(new
            {
                ValorActual = "Parámetros para usar cuando sea posible",
                Descripcion = "Ejemplo en MODO NO ASYNC - DEBE SER ASÍNCRONOS",
                Valores = list,
            });
        }
    }
}
