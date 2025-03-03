using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRS.Queries.MovieQueries;
using MovieApi.Application.Features.CQRS.Results.MovieResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieContext _context;
        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
        {
            var value = await _context.Movies.FirstOrDefaultAsync(x => x.MovieID == query.Id);
            return new GetMovieByIdQueryResult
            {
                MovieID = value.MovieID,
                Title = value.Title,
                CoverImageUrl = value.CoverImageUrl,
                Rating = value.Rating,
                Description = value.Description,
                Duration = value.Duration,
                ReleaseDate = value.ReleaseDate,
                CreatedYear = value.CreatedYear,
                Status = value.Status
            };
        }
    }
}
