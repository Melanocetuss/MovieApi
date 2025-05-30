using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Results.TagResults
{
    public class GetTagQueryResult
    {
        public int TagID { get; set; }
        public string Name { get; set; }
    }
}