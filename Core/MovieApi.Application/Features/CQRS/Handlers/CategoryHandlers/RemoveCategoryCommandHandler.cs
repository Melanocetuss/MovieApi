using MovieApi.Application.Features.CQRS.Commands.CategoryCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;
        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(RemoveCategoryCommand command) 
        {
            var value =  await _context.Categories.FindAsync(command.Id);
            _context.Categories.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}