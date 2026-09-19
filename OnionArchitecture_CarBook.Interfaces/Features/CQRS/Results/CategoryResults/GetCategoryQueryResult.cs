using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Application.Features.CQRS.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
