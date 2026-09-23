using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.CQRS.Queries.CarQueries
{
    public class GetCarByIdQuery
    {
        public int Id { get; set; }

        public GetCarByIdQuery(int id)
        {
            Id = id;
        }
    }
}
