using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands
{
    public class RemoveMovieCommand
    {
        public int MovieID { get; set; }
        public RemoveMovieCommand(int movieID)
        {
            MovieID = movieID;
        }
    }
}