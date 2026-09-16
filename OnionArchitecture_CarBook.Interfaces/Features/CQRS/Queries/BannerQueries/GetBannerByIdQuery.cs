using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Application.Features.CQRS.Queries.BannerQueries
{
    public class GetBannerByIdQuery
    {
        public GetBannerByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
