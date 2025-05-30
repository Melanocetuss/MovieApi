using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class CreateTagCommandHandler : IRequestHandler<CreateCastCommand>
    {
        private readonly MovieContext _context;
        public CreateTagCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
            _context.Tags.Add(new Tag
            {
                Name = request.Name
            });
            await _context.SaveChangesAsync();
        }
    }
}