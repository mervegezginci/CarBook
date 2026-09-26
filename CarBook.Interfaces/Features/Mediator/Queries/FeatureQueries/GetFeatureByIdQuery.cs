using CarBook.Application.Features.Mediator.Results.FeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery:IRequest<GetFeatureByIdQueryResult>
    {
        public int Id { get; set; }

        public GetFeatureByIdQuery(int id)
        {
            Id = id;
        }
    }
}
