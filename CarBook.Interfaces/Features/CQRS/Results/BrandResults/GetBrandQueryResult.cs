using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.CQRS.Results.BrandResults
{
    public class GetBrandQueryResult
    {
        public int BrandID { get; set; }
        public string Name { get; set; }
    }
}
