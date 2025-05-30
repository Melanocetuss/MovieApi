using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers;
using MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly GetMovieQueryHandler _getMovieQueryHandler;
        private readonly GetMovieByIdQueryHandler _getMovieByIdQueryHandler;
        private readonly CreateMovieCommandHandler _createMovieCommandHandler;
        private readonly UpdateMovieCommandHandler _updateMovieCommandHandler;
        private readonly RemoveMovieCommandHandler _removeMovieCommandHandler;

        public MoviesController(GetMovieQueryHandler getMovieQueryHandler,
                                GetMovieByIdQueryHandler getMovieByIdQueryHandler,
                                CreateMovieCommandHandler createMovieCommandHandler,
                                UpdateMovieCommandHandler updateMovieCommandHandler,
                                RemoveMovieCommandHandler removeMovieCommandHandler)
        {
            _getMovieQueryHandler = getMovieQueryHandler;
            _getMovieByIdQueryHandler = getMovieByIdQueryHandler;
            _createMovieCommandHandler = createMovieCommandHandler;
            _updateMovieCommandHandler = updateMovieCommandHandler;
            _removeMovieCommandHandler = removeMovieCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> MovieList()
        {
            var value = await _getMovieQueryHandler.Handle();
            return Ok(value);
        }

        [HttpGet("GetMovie")]
        public async Task<IActionResult> GetMovie(int MovieID)
        {
            var value = await _getMovieByIdQueryHandler.Handle(new GetMovieByIdQuery(MovieID));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(CreateMovieCommand command)
        {
            await _createMovieCommandHandler.Handle(command);
            return Ok("Film Ekleme İşlemi Başarılı.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveMovie(int MovieID)
        {
            await _removeMovieCommandHandler.Handle(new RemoveMovieCommand(MovieID));
            return Ok("Film Silme İşlemi Başarılı.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMovie(UpdateMovieCommand command)
        {
            await _updateMovieCommandHandler.Handle(command);
            return Ok("Film Güncelleme İşlemi Başarılı.");
        }
    }
}