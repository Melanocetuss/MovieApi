using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands
{
    public class UpdateCastCommand : IRequest
    {
        public int CastID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CoverImageUrl { get; set; }
        public string? OverView { get; set; }
        public string? Biography { get; set; }
    }
}