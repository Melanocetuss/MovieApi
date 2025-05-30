using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands
{
    public class UpdateCategoryCommand
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}