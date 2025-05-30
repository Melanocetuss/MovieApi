using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult CastList()
        {
            var values = _mediator.Send(new GetCastQuery());
            return Ok(values);
        }

        [HttpGet("GetCast")]
        public IActionResult GetCast(int CastID)
        {
            var values = _mediator.Send(new GetCastByIdQuery(CastID));
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCast(CreateCastCommand command)
        {
            _mediator.Send(command);
            return Ok("Oyuncu Kadrosu Ekleme İşlemi Başarılı.");
        }

        [HttpDelete]
        public IActionResult RemoveCast(int CastID)
        {
            _mediator.Send(new RemoveCastCommand(CastID));
            return Ok("Oyuncu Kadrosu Silme İşlemi Başarılı.");
        }

        [HttpPut]
        public IActionResult UpdateCast(UpdateCastCommand command)
        {
            _mediator.Send(command);
            return Ok("Oyuncu Kadrosu Güncelleme İşlemi Başarılı.");
        }

    }
}