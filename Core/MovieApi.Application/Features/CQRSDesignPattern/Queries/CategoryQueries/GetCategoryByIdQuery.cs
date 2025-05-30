using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery
    {
        public int CategoryID { get; set; }
        public GetCategoryByIdQuery(int categoryID)
        {
            CategoryID = categoryID;
        }
    }
}