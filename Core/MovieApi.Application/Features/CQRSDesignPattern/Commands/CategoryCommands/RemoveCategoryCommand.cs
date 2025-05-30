using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands
{
    public class RemoveCategoryCommand
    {
        public int CategoryID { get; set; }
        public RemoveCategoryCommand(int categoryID)
        {
            CategoryID = categoryID;
        }
    }
}