using MovieApi.Application.Features.CQRS.Commands.MovieCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler
    {
        private readonly MovieContext _context;
        public RemoveMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(RemoveMovieCommand command) 
        {
            var value = await _context.Movies.FindAsync(command.Id);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}