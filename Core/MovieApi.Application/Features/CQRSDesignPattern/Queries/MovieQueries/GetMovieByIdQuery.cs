using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries
{
    public class GetMovieByIdQuery
    {
        public int MovieID { get; set; }
        public GetMovieByIdQuery(int movieID)
        {
            MovieID = movieID;
        }
    }
}
