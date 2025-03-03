using MovieApi.Application.Features.CQRS.Commands.CategoryCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly MovieContext _context;
        public UpdateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCategoryCommand command) 
        {
            var value = await _context.Categories.FindAsync(command.CategoryID);
            value.CategoryName = command.CategoryName;
            await _context.SaveChangesAsync();
        }
    }
}