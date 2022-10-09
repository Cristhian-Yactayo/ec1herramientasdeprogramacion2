using api_empresa.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_empresa.Controllers
{
    //decimos que es un controlador
    [ApiController]

    //es definir la ruta de acceso al controlador
    [Route("api-empresa/empresa")]

    //controlador base es una herencia para que sea controlador
    public class EmpresaController: ControllerBase
    {
        private readonly ApplicationDBContext context;

        //creamos el metodo constructor
        public EmpresaController(ApplicationDBContext context)
        {
            this.context = context;
        }

        //cuando queremos obtener informacion
        [HttpGet]
        public async Task<ActionResult<List<Empresa>>> findAll()
        {
            return await context.Empresa.ToListAsync();
        }
        //cuando queremos guardar informacion
        [HttpPost]
        public async Task<ActionResult> add(Empresa e)
        {
            context.Add(e);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
