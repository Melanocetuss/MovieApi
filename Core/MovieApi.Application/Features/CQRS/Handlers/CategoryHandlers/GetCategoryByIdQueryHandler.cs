using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRS.Queries.CategoryQueries;
using MovieApi.Application.Features.CQRS.Results.CategoryResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly MovieContext _context;
        public GetCategoryByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var value = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryID == query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryID = value.CategoryID,
                CategoryName = value.CategoryName
            };
        }
    }
}