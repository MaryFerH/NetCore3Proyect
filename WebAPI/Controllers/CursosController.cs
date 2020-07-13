using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Cursos;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //http://localhost:500/api/Cursos
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController:ControllerBase
    {
        private readonly IMediator _mediator;
        public CursosController(IMediator mediator){
            _mediator=mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Curso>>> Get(){
            return await _mediator.Send(new Consulta.ListaCursos());
        }
    }
}