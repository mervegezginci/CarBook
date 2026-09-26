using MediatR;
using CarBook.Application.Features.Mediator.Results.FeatureResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>>
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
    }
}
