﻿using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class RemoveTagCommandHandler : IRequestHandler<RemoveTagCommand>
    {
        private readonly MovieContext _context;
        public RemoveTagCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Tags.Find(request.TagID);
            _context.Tags.Remove(values);
            return _context.SaveChangesAsync();
        }
    }
}