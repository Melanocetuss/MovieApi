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
        public async Task<IActionResult> CastList()
        {
            var values = await _mediator.Send(new GetCastQuery());
            return Ok(values);
        }

        [HttpGet("GetCast")]
        public async Task<IActionResult> GetCast(int CastID)
        {
            var values = await _mediator.Send(new GetCastByIdQuery(CastID));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCast(CreateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok("Oyuncu Kadrosu Ekleme İşlemi Başarılı.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCast(int CastID)
        {
            await _mediator.Send(new RemoveCastCommand(CastID));
            return Ok("Oyuncu Kadrosu Silme İşlemi Başarılı.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCast(UpdateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok("Oyuncu Kadrosu Güncelleme İşlemi Başarılı.");
        }

    }
}